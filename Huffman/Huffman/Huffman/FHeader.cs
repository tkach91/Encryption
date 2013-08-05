using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    [Serializable]
    class FHeader
    {
        public readonly FreqTable FT;
        public readonly long baseSize;
        public readonly byte complementsBits;

        public FHeader(FreqTable T, ref long bSize, byte BitsToFill)
        {
            FT = T;
            baseSize = bSize;
            complementsBits = BitsToFill;
        }
    }

    [Serializable]
    class FreqTable
    {
        public Byte[] foundBytes;   // таблица символов
        public uint[] freq;         // количество повторов
    }
}
