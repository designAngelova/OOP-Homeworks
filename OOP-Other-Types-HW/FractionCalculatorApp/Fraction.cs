using System;

namespace FractionCalculatorApp
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long num, long denom) : this()
        {
            this.Numerator = num;
            this.Denominator = denom;
        } 

        public long Numerator
        {
            get { return this.numerator; }
            private set { this.numerator = value; }
        }

        public long Denominator
        {
            get { return this.denominator; }
            private set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator cannot be zero", "denominator");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long multiple = lcm(f1.Denominator, f2.Denominator);
            long leftSide = f1.Numerator * multiple/f1.Denominator;
            long rightSide = f2.Numerator * multiple / f2.Denominator;

            return new Fraction(leftSide + rightSide, multiple);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long multiple = lcm(f1.Denominator, f2.Denominator);
            long leftSide = f1.Numerator * multiple / f1.Denominator;
            long rightSide = f2.Numerator * multiple / f2.Denominator;

            return new Fraction(leftSide - rightSide, multiple);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
        }

        public static decimal ToDecimal(Fraction f)
        {
            return (decimal) f.Numerator / f.Denominator;
        }

        private static long lcm(long a, long b)
        {
            long temp = gcd(a, b);

            return temp > 0 ? (a / temp * b) : 0;
        }

        private static long gcd(long a, long b)
        {
            while (true)
            {
                if (a == 0) { return b; }
                b %= a;

                if (b == 0) { return a; }
                a %= b;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}", (decimal) numerator / denominator);
        }
    }
}
