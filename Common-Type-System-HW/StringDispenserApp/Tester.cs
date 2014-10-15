using System;

namespace StringDispenserApp
{
    public class Tester
    {
        public static void Main()
        {
            StringDispenser stringDisperser = new StringDispenser("gosho", "pesho", "tanio");
            StringDispenser copyOfDispenser = stringDisperser.Clone();

            copyOfDispenser.StringHolder.Append("asdasd");

            // The original stringDispenser hasn`t changed
            foreach (var ch in stringDisperser)
            {
                Console.Write(ch + " ");
            }
        }
    }
}
