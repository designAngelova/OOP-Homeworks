namespace BitArray
{
    using System;
    using System.Numerics;

    public static class StringExtension
    {
        public static string ToBigInteger(this string binary)
        {
            BigInteger accumInteger = new BigInteger();
            int multiplyer = 1;

            for (int i = binary.Length - 1; i >= 0; i--)
            {
                if (binary[i] == '1')
                {
                    accumInteger += (int) Math.Pow(2, multiplyer);
                }

                multiplyer++;
            }

            return accumInteger.ToString();
        }
    }
}
