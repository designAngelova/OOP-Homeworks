using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitArray_Imp
{
    public static class StringExtension
    {
        public static string ToDecimal(this string binary)
        {
            BigInteger result = new BigInteger();
            int exponent = 1;

            for (int i = binary.Length - 1; i >= 0 ; i--)
            {
                if (binary[i] == '1')
                {
                    result += (BigInteger) Math.Pow(2, exponent);
                }
                exponent++;
            }

            return result.ToString();
        }
    }
}
