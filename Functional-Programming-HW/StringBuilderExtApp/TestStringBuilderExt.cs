using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuilderExtApp
{
    public class TestStringBuilderExt
    {
        public static void Main()
        {
            StringBuilder mySb = new StringBuilder("Lorem ipsum loremlorem obenadi");

            Console.WriteLine(mySb.Substring(1, 10));
            mySb = mySb.RemoveText("lorem");

            mySb = mySb.AppendAll(new List<string>()
            {
                "valeri", "asen"
            });

            Console.WriteLine(mySb);
        }
    }
}
