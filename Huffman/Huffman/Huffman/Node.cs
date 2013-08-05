using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Huffman
{
    class Node
    {
        private Node LSon = null,
                     RSon = null,
                     P = null; // указатели на другие элементы структуры
        private byte ch;       // символ
        private uint count;    // количество повторений

        public Node Left
        {
            get
            {
                return this.LSon;
            }
            set
            {
                this.LSon = value;
            }
        }

        public Node Right 
        {
            get
            {
                return this.RSon;
            }
            set
            {
                this.RSon = value;
            }
        }

        public Node Parent
        {
            get
            {
                return this.P;
            }
            set
            {
                this.P = value;
            }
        }

        public byte BVal
        {
            get
            {
                return this.ch;
            }
            set
            {
                this.ch = value;
            }
        }

        public uint cVal
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }
    }
}
