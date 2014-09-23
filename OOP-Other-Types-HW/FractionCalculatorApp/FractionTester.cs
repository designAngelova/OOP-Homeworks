using System;

namespace FractionCalculatorApp
{
    public class FractionTester
    {
        public static void Main()
        {
            Fraction f1 = new Fraction(22, 11);
            Fraction f2 = new Fraction(40, 4);

            Fraction result = f1 / f2;

            //Console.WriteLine(result.Numerator);
            //Console.WriteLine(result.Denominator);
            //Console.WriteLine(result);

            Console.WriteLine("Please enter a fraction expression (i.e 1/4 + 4/5):");
            string expression = Console.ReadLine();

            Console.WriteLine(expression.CalculateFractionFromString());
        }
    }
}
