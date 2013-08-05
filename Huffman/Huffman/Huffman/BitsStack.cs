using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    class BitsStack
    {
        public Byte Container;
        private byte Amount;

        public BitsStack() { }

        public BitsStack(Byte D)
        {
            FillStack(D);    
        }

        public bool IsFull()
        {
            return Amount == 8;
        }

        public bool IsEmpty()
        {
            return Amount == 0;
        }

        public Byte NumOfBits()
        {
            return Amount;
        }

        public void Clear()
        {
            Amount = Container = 0;
        }

            // Помешает бит с левой стороны (наибольший разряд)
        public void PushFlag(bool Flag)
        {
            if (Amount == 8) 
                throw new Exception("Стек полон");
            Container >>= 1;
            if (Flag) Container |= 128;
            Amount++;
        }

            // Извлекает бит с правой стороны (наименьший разряд)
        public bool PopFlag()
        {
            if (Amount == 0)
                throw new Exception("Стек пуст");
            bool t = (Container & 1) != 0;
            Amount--;
            Container >>= 1;
            return t;
        }

            // Заполняет стек данными (8 битами). Переписывает старые значения.
        public void FillStack(Byte Data)
        {
            Container = Data;
            Amount = 8;
        }
    }
}
