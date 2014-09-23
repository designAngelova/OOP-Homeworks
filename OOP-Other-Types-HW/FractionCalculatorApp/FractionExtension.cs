using System;
using System.Text.RegularExpressions;

namespace FractionCalculatorApp
{
    public static class FractionExtension
    {
        public static decimal CalculateFractionFromString(this string expression)
        {
            Regex regex = new Regex(@"\s*(\d+)\s*\/(\d+)\s*([-+/*])\s*(\d+)\s*\/(\d+)\s*");
            Match m = regex.Match(expression);

            long f1Numerator = Int64.Parse(m.Groups[1].Value);
            long f1Denomimator = Int64.Parse(m.Groups[2].Value);
            string oper = m.Groups[3].Value;
            long f2Numerator = Int64.Parse(m.Groups[4].Value);
            long f2Denominator = Int64.Parse(m.Groups[5].Value);

            Fraction f1 = new Fraction(f1Numerator, f1Denomimator);
            Fraction f2 = new Fraction(f2Numerator, f2Denominator);
            Fraction result = new Fraction();

            if (oper == "+")
            {
                result = f1 + f2;
            }
            else if (oper == "-")
            {
                result = f1 - f2;
            }
            else if (oper == "*")
            {
                result = f1 - f2;
            }
            else if (oper == "/")
            {
                result = f1 - f2;
            }

            return Fraction.ToDecimal(result);
        }
    }
}
