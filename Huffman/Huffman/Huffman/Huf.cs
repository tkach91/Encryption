using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace Huffman
{
    class Huf
    {
        private Byte[] ByteLocation = new Byte[256];               // массив, хранящий позиции байт  в amountlist
        private bool[] ExistBytes;                                 // массив, хранящий true, если индекс массива был встречен в потоке, иначе false
        private ArrayList BytesList = new ArrayList();             // найденные байты
        private ArrayList AmountList = new ArrayList();            // их количество
        private ArrayList BitsList = new ArrayList();              // обратный путь  в дереве
        private BinaryFormatter BinFormat = new BinaryFormatter(); // чтение заголовка
        private BitsStack Stack = new BitsStack();                 //запись байт

        internal class HuffmanTree
        {
            public readonly Node[] Leafs;                       //листья
            public readonly FreqTable FT;                       //таблица частот
            private ArrayList OrphanNodes = new ArrayList();    // список узлов
            public readonly Node RootNode;                      //корень

            internal HuffmanTree(FreqTable FT)
            {
                ushort Length = (ushort)FT.foundBytes.Length;
                this.FT = FT;
                Leafs = new Node[Length];
                if (Length >= 1)
                {
                    for (ushort i = 0; i < Length; ++i)
                    {
                        Leafs[i] = new Node();
                        Leafs[i].BVal = FT.foundBytes[i];
                        Leafs[i].cVal = FT.freq[i];
                    }
                    OrphanNodes.AddRange(Leafs);
                    RootNode = BuildTree();
                }
                OrphanNodes.Clear();
                OrphanNodes = null;
            }

            // Построение дерева Хаффмана из таблицы частот (подфункция)
            private Node BuildTree()
            {
                Node small, smaller, NewParentNode = null;
                // Останавливаемся, когда остается только один корень
                while (OrphanNodes.Count > 1)
                {
                    FindSmallestOrphanNode(out smaller);
                    FindSmallestOrphanNode(out small);
                    NewParentNode = new Node();
                    NewParentNode.cVal = small.cVal + smaller.cVal;
                    NewParentNode.Left = smaller;
                    NewParentNode.Right = small;
                    smaller.Parent = small.Parent = NewParentNode;
                    OrphanNodes.Add(NewParentNode);
                }
                return NewParentNode;//возвращаем корень
            }

            private void FindSmallestOrphanNode(out Node Smallest)
            {
                Smallest = null;
                ulong Tempvalue = ulong.MaxValue;
                Node TempNode = null;
                int i, j = 0;
                int ArrSize = OrphanNodes.Count - 1;
                // Ищем наименьшее
                for (i = ArrSize; i != -1; --i)
                {
                    TempNode = (Node)OrphanNodes[i];    //добавляем в список узлов
                    if (TempNode.cVal < Tempvalue)
                    {
                        Tempvalue = TempNode.cVal;
                        Smallest = TempNode;
                        j = i;
                    }
                }
                OrphanNodes.RemoveAt(j); //удаляем наименьший узел(по колву встречаемости)
                ArrSize--;
            }
        }

        private FreqTable BuildFrequencyTable(Stream DataSource)
        {
            long OriginalPosition = DataSource.Position;
            FreqTable FT = new FreqTable();
            ExistBytes = new bool[256]; //false по умолчанию

            Byte bTemp;
            // Подсчитывыет байты и сохраняет их
            for (long i = 0; i < DataSource.Length; ++i)
            {
                bTemp = (Byte)DataSource.ReadByte();
                if (ExistBytes[bTemp]) // Если байт уже найден ранее, увеличиваем его счетчик повторов
                    AmountList[ByteLocation[bTemp]] = (uint)AmountList[ByteLocation[bTemp]] + 1;
                else // Если байт новый (не встречаемый ранее)
                {
                    ExistBytes[bTemp] = true; // Помечаем байт
                    ByteLocation[bTemp] = (Byte)BytesList.Count; // Сохраняем новую позицию байта
                    AmountList.Add(1u); // Помечаем, что один был найден 
                    BytesList.Add(bTemp);
                }
            }
            int ArraySize = BytesList.Count;
            FT.foundBytes = new byte[ArraySize];
            FT.freq = new uint[ArraySize];
            short ArraysSize = (short)ArraySize;
            // Копируем список в массивы
            for (short i = 0; i < ArraysSize; ++i)
            {
                FT.foundBytes[i] = (Byte)BytesList[i];
                FT.freq[i] = (uint)AmountList[i];
            }
            // Сортируем массивы по частоте
            Sort.SortArrays(FT.freq, FT.foundBytes, ArraysSize, ByteLocation);

            // Очищаем ресурсы
            ExistBytes = null;
            BytesList.Clear();
            AmountList.Clear();
            DataSource.Seek(OriginalPosition, SeekOrigin.Begin);
            return FT;
        }

        /*** Строит таблицу частот, дерево Хаффмана и упаковывает поток данных ***/

        // Поток данных для сжатия, по окончания он не будет закрыт, позиция не изменится,
        // архивирование начинается с текущей позиции в потоке
        public void Shrink(Stream Data, string OutputFile)
        {
            // Исключение для длины = 0
            if (Data.Length == 0)
            {
                FileStream tempFS2 = new FileStream(OutputFile, FileMode.Create);
                tempFS2.Close();
                return;
            }

            // Генерируем заголовок и создаем дерево Хаффмана
            HuffmanTree HT = new HuffmanTree(BuildFrequencyTable(Data));
            // Создаем выходной файл
            FileStream tempFS = new FileStream(OutputFile, FileMode.Create);
            // Записываем в него заголовок
            WriteHeader(tempFS, HT.FT, Data.Length, GetComplementsBits(HT));
            long DataSize = Data.Length;
            Node TempNode = null;
            Byte Original; // Байт, считанный из входного потока

            short j; int k;
            for (long i = 0; i < DataSize; ++i)
            {
                Original = (Byte)Data.ReadByte();
                TempNode = HT.Leafs[ByteLocation[Original]];
                while (TempNode.Parent != null)
                {
                    // Если это левое поддерево, то записываем 1, иначе 0
                    BitsList.Add(TempNode.Parent.Left == TempNode);
                    TempNode = TempNode.Parent; // Двигаемся вверх по дереву
                }
                BitsList.Reverse();
                k = BitsList.Count;
                for (j = 0; j < k; ++j)
                {
                    Stack.PushFlag((bool)BitsList[j]);
                    if (Stack.IsFull())
                    {
                        tempFS.WriteByte(Stack.Container);
                        Stack.Clear();
                    }
                }
                BitsList.Clear();
            }

            // Записывает последний байт, если стек не был полностью заполнен
            if (!Stack.IsEmpty())
            {
                Byte BitsToComplete = (Byte)(8 - Stack.NumOfBits());
                // Дополняем стек до максимума
                for (byte Count = 0; Count < BitsToComplete; ++Count)
                    Stack.PushFlag(false);
                tempFS.WriteByte(Stack.Container);
                Stack.Clear();
            }
            tempFS.Seek(0, SeekOrigin.Begin);
            tempFS.Close();
        }

        // Строим таблицу частот, дерево Хаффмана и записываем извлеченные данные в новый файл
        public bool Extract(Stream Data, string OutputFile)
        {
            // Исключение для длины = 0
            if (Data.Length == 0)
            {
                FileStream tempFS2 = new FileStream(OutputFile, FileMode.Create);
                tempFS2.Close();
                return true;
            }

            Data.Seek(0, SeekOrigin.Begin);
            FHeader Header;

            // Читаем заголовок
            if (!IsArchivedStream(Data)) throw new Exception("Поток возможно поврежден или не упакован!");
            Header = (FHeader)BinFormat.Deserialize(Data);

            // Обработка исключительно ситуации при длине равной 1
            if (Header.baseSize == 1)
            {
                FileStream tempFS3 = new FileStream(OutputFile, FileMode.Create);
                tempFS3.WriteByte(Header.FT.foundBytes[0]);
                tempFS3.Close();
                return true;
            }

            // Генерируем дерево Хаффмана из таблицы частот
            HuffmanTree HT = new HuffmanTree(Header.FT);
            // Создаем выходной файл
            FileStream tempFS = new FileStream(OutputFile, FileMode.Create);
            BitsStack Stack = new BitsStack();
            long DataSize = Data.Length - Data.Position;
            if (Header.complementsBits == 0) DataSize += 1;
            Node TempNode = null;

            while (true)
            {
                TempNode = HT.RootNode;
                // Пока это не лист, двигаемся вниз по дереву
                while (TempNode.Left != null && TempNode.Right != null)
                {
                    /// Когда стек пуст заполняем его новыми данными
                    if (Stack.IsEmpty())
                    {
                        Stack.FillStack((Byte)Data.ReadByte());
                        if ((--DataSize) == 0)
                        {
                            goto AlmostDone;
                        }
                    }
                    // В зависимости от бита выбираем левое или правое поддерево
                    TempNode = Stack.PopFlag() ? TempNode.Left : TempNode.Right;
                }
                // Достигли листа, записываем его значение
                tempFS.WriteByte(TempNode.BVal);
            }

            // Остался только один байт
        AlmostDone:
            short BitsLeft = (Byte)(Stack.NumOfBits() - Header.complementsBits);

            // Записываем оставшуюся часть байта
            if (BitsLeft != 8)
            {
                bool Leaf = TempNode.Left == null && TempNode.Right == null;
                while (BitsLeft > 0)
                {
                    if (Leaf) TempNode = HT.RootNode;
                    while (TempNode.Left != null && TempNode.Right != null)
                    {
                        // перемещаемся в левое или правое поддерево в зависимости от значения бита
                        TempNode = Stack.PopFlag() ? TempNode.Left : TempNode.Right;
                        --BitsLeft;
                    }
                    // Достигли листа, записываем его значение
                    tempFS.WriteByte(TempNode.BVal);
                    Leaf = true;
                }
            }

            tempFS.Close();
            return true;
        }

        // Проверка на то, что данный поток является архивом
        public bool IsArchivedStream(Stream Data)
        {
            Data.Seek(0, SeekOrigin.Begin);
            bool test = true;
            try
            {
                FHeader Header = (FHeader)BinFormat.Deserialize(Data);
                Header = null;
            }
            catch (Exception)
            {
                test = false;
            }
            finally
            {
                Data.Seek(0, SeekOrigin.Begin);
            }
            return test;
        }

        // Пишем заголовок в поток, необходимый для извлечения данных
        private void WriteHeader(Stream St, FreqTable FT, long OriginalSize,
             Byte ComplementsBits)
        {
            FHeader Header = new FHeader(FT, ref OriginalSize,
                ComplementsBits);
            BinFormat.Serialize(St, Header);
        }

        // Подсчитывает число завершающих битов для завершения последнего байта
        private Byte GetComplementsBits(HuffmanTree HT)
        {
            // Получаем глубину каждого листа дерева Хаффмана
            short i = (short)HT.Leafs.Length;
            ushort[] NodesDeapth = new ushort[i];
            long SizeInOfBits = 0;
            while (--i != -1)
            {
                Node TN = HT.Leafs[i];
                while (TN.Parent != null)
                {
                    TN = TN.Parent;
                    ++NodesDeapth[i];
                }
                SizeInOfBits += NodesDeapth[i] * HT.FT.freq[i];
            }
            return (byte)(8 - SizeInOfBits % 8);
        }
    }
}