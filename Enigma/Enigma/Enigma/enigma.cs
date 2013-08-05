using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigma
{

    public class enigmaKey
    {
        readonly public byte[] Rotor1 = new byte[256];
        readonly public byte[] Rotor2 = new byte[256];
        readonly public byte[] Rotor3 = new byte[256];
        readonly public byte[] Reflect = new byte[256];

            // В конструктуоре инициализируем наши таблицы с помощью класса Random
            // Т.к. используется вторая реализация Random, то при генерации таблиц 
            // для дешивровки достаточно будет использовать те же самые инициализирующие значения
        public enigmaKey()
        {
            Random rand1 = new Random(125);
            Random rand2 = new Random(13);
            Random rand3 = new Random(817);
            Random rand4 = new Random(347);

            initRotor(Rotor1, rand1);
            initRotor(Rotor2, rand2);
            initRotor(Rotor3, rand3);
            initReflector(Reflect, rand4);
        }

        //==========TESTS==========//
        public bool ab_ba_test(byte[] rot)
        {
            for (int i = 0; i < rot.Length; i++)
            {
                if (rot[rot[i]] != i)
                {
                    return false;
                }
            }
            return true;
        }

        public int fixedPointCount_test(byte[] rot)
        {
            int res = 0;
            for (int i = 0; i < rot.Length; i++)
            {
                if (rot[i] == i) res++;
            }
            return res;
        }

        public bool unique_test(byte[] rot)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < rot.Length; i++)
            {
                if (set.Contains(i))
                    return false;
                set.Add(i);
            }
            return true;
        }
        //========END_TESTS========//

        public void initReflector(byte[] r, Random rand)
        {
            HashSet<int> excluded = new HashSet<int>(); 
            for (int i = 0; i < r.Length; i++)
            {
                r[i] = (byte)i;
            }

            int target;
            for (int i = 0; i < r.Length; i++)
            {
                if (!excluded.Contains(i))
                {
                    do
                    {
                        target = rand.Next(256 - i) + i;
                    } while (excluded.Contains(target));

                    int tmp = r[i];
                    r[i] = r[target];
                    r[target] = (byte)tmp;
                    excluded.Add(target);
                }
            }
        }

            // Генерация случайной последовательности кодов от 0 до 255
        public void initRotor(byte[] Rotor, Random rand)
        {
            int iNumbersCount = 256;
            int[] aNumbers = new int[iNumbersCount];
            for (int i = 0; i < aNumbers.Length; i++)
                aNumbers[i] = i;

            for (int i = 0; i < 256; i++)
            {
                int iIndex = rand.Next(iNumbersCount);
                Rotor[i] = (byte)aNumbers[iIndex];
                aNumbers[iIndex] = aNumbers[iNumbersCount - 1];
                iNumbersCount--;
            }
        }
    }

    public class enigma_cript
    {
        enigmaKey ek;

        public enigma_cript()
        {
            ek = new enigmaKey();
        }

            // Кодировать
        public void crypt(byte[] in_array, byte[] out_array)
        {
            int d1 = 0, d2 = 0, d3 = 0;
            for (int i = 0; i < in_array.Length; i++)
            {
                byte p1, p2, p3, p4;

                p1 = ek.Rotor1[(in_array[i] + d1) % 256];
                p2 = ek.Rotor2[(p1 + d2) % 256];
                p3 = ek.Rotor3[(p2 + d3) % 256];
                p4 = ek.Reflect[p3 % 256];
                // хрень начинается
                int index = p4;
                for (int j = 0; j <= 255; j++)
                {
                    if (ek.Rotor3[j] == index)
                    {
                        index = (j - d3 + 256) % 256;
                        break;
                    }
                }
                for (int j = 0; j <= 255; j++)
                {
                    if (ek.Rotor2[j] == index)
                    {
                        index = (j - d2 + 256) % 256;
                        break;
                    }
                }
                for (int j = 0; j <= 255; j++)
                {
                    if (ek.Rotor1[j] == index)
                    {
                        index = (j - d1 + 256) % 256;
                        break;
                    }
                }
                // хрень заканчивается
                out_array[i] = (byte)index;
                // хрень сработала
                d1++;
                if (d1 % 256 == 0)
                {
                    d1 = 0;
                    d2++;
                    if (d2 % 256 == 0)
                    {
                        d2 = 0;
                        d3++;
                        if (d3 % 256 == 0) 
                            d3 = 0;
                    }
                }
            }
        }
    }
}
