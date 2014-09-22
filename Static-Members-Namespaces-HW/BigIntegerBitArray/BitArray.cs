using System;
using System.Linq;

namespace BigIntegerBitArray
{

    public class BitArray
    {
        private bool[] bitHolder;
        private int size;

        public BitArray(int size)
        {
            this.Size = size;
            this.bitHolder = new bool[size];
        }

        public int Size
        {
            get { return this.size; }
            private set
            {
                if (value < 0 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("size", "Array size limitations: [0 - 100000]");
                }

                this.size = value;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > this.size - 1)
                {
                    throw new IndexOutOfRangeException("You are trying to access an index that doesn`t exist");
                }

                return this.bitHolder[index] ? 1 : 0;
            }

            set
            {
                if (index < 0 || index > this.size - 1)
                {
                    throw new IndexOutOfRangeException("You are trying to access an index that doesn`t exist");
                }

                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("bool array requires bool input");
                }

                this.bitHolder[index] = value == 1 ? true : false;
            }
        }

        public override string ToString()
        {
            return String.Join("", this.bitHolder.Select(b => b ? 1 : 0).ToArray());
        }
    }

    public class BitArrayTester
    {
        public static void Main()
        {
            BitArray myArray = new BitArray(433);

            myArray[1] = 1;
            myArray[1] = 0;
            myArray[311] = 1;
            myArray[122] = 1;
            myArray[431] = 1;

            string decimalValue = myArray.ToString().ToBigInteger();

            Console.WriteLine(decimalValue);
        }
    }
}
