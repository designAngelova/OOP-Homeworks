using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray_Imp
{
    class BitArray
    {
        public uint[] bigInteger;
        private int arrayCount;
        private int bits;

        public BitArray(int bits)
        {
            this.Bits = bits;
            this.arrayCount = (int) this.Bits / 32;
            bigInteger = new uint[this.arrayCount + 1];
        }

        public int Bits
        {
            get { return bits; }
            private set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("bits", "Please enter a value between [1...100000]");
                }

                bits = value;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > this.Bits - 1)
                {
                    throw new ArgumentOutOfRangeException("index", "You are trying to access an array index that doesn`t exist!");
                }

                return ((this.bigInteger[index/32] & (1 << index)) == 0) ? 0 : 1;
            }
            set
            {
                if (index < 0 || index > this.Bits)
                {
                    throw new ArgumentOutOfRangeException("index - set", "Index is not available");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("invalid value", "Bit values: [1 or 0]");
                }
                int idx = (int) index/32;
                this.bigInteger[idx] ^= (uint)(1 << (index % 32));
                this.bigInteger[idx] |= (uint)1 << (index % 32);
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(bigInteger.Length * 32);

            for (int i = 0; i < bigInteger.Length; i++)
            {
                uint temp = ~bigInteger[i];
                while (temp != 0)
                {
                    sb.Append((1 & temp) == 0 ? "1" : "0");
                    temp = temp >> 1;
                }
            }

            return sb.ToString();
        }
    }

    class Tester
    {
        public static void Main()
        {
            BitArray bigNumber = new BitArray(8);

            bigNumber[7] = 1;

            Console.WriteLine(StringExtension.ToDecimal(bigNumber.ToString()));
            
        }
    }
}


