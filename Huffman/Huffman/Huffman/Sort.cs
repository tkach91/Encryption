using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    class Sort
    {
        // Сортировка пузырьком по частоте встречаемости
        // Делает такие же изменеия в массиве - близнеце
        public static void SortArrays(uint[] SortTarget, Byte[] TweenArray, short size, Byte[] BLoc)
        {
            size--;
            bool TestSwitch = false;
            Byte BTemp;
            uint uiTemp;
            short i, j;
            for (i = 0; i < size; ++i)
            {
                for (j = 0; j < size; ++j)
                {
                    if (SortTarget[j] < SortTarget[j + 1])
                    {
                        TestSwitch = true;
                        uiTemp = SortTarget[j];
                        SortTarget[j] = SortTarget[j + 1];
                        SortTarget[j + 1] = uiTemp;
                        // Делаем то же в массиве - близнеце
                        BTemp = TweenArray[j];
                        TweenArray[j] = TweenArray[j + 1];
                        TweenArray[j + 1] = BTemp;
                    }
                }
                if (!TestSwitch) break; // Если не было перестановок, то выходим из цикла
                TestSwitch = false;
            }
            for (i = 0; i < SortTarget.Length; ++i)
                BLoc[TweenArray[i]] = (Byte)i;
        }
    }
}
