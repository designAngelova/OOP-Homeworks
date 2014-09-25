using System;
using System.Globalization;
using System.Threading;

namespace InterestCalculatorApp
{
    public class InterestCalculator
    {
        private decimal interest;

        public InterestCalculator(decimal money, double interest, int years,
            Func<decimal, double, int, decimal> intrsFunc)
        {
            this.interest = intrsFunc(money, interest, years);
        }

        public decimal Interest
        {
            get { return interest; }
            private set { interest = value; }
        }
    }

    public class TestInterestCalc
    {
        private const int Period = 12;

        private delegate decimal CalculateInterest(Func<decimal, decimal, int> interestFormula);

        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Func<decimal, double, int, decimal> GetSimpleInterest =
                (sum, intr, years) => Math.Round(sum * (decimal) (1 + (intr / 100) * years), 4);

            Func<decimal, double, int, decimal> GetCompoundInterest =
                (sum, intr, years) => 
                    Math.Round(sum * (decimal) Math.Pow(1 + (intr / 100) / Period, years * Period), 4);

            InterestCalculator myCalc1 = new InterestCalculator(500.00m, 5.6, 10, GetCompoundInterest);
            InterestCalculator myCalc2 = new InterestCalculator(2500.00m, 7.2, 15, GetSimpleInterest);

            Console.WriteLine(myCalc1.Interest);
            Console.WriteLine(myCalc2.Interest);
        }
    }
}
