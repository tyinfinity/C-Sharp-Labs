using System;

namespace Task2
{
    internal class Fraction
    {
        private long denominator;

        public long Numerator { get; set; }
        public long Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException();
                }

                denominator = value;

                if (value < 0)
                {
                    Numerator *= -1;
                    denominator *= -1;
                }
            }
        }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(long numerator, long denominator)
        {
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            if (numerator == 0)
            {
                denominator = 1;
            }

            if (denominator == 0)
            {
                throw new Exception("Нельзя делить на 0.");
            }

            long nod = Nod(numerator, denominator);
            numerator /= nod;
            denominator /= nod;

            Numerator = numerator;
            Denominator = denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj is not Fraction f)
            {
                return false;
            }

            return (Numerator == f.Numerator) && (Denominator == f.Denominator);
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(CalculateNumerator(Nok(fraction1, fraction2), fraction1) + CalculateNumerator(Nok(fraction1, fraction2), fraction2), Nok(fraction1, fraction2));
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(CalculateNumerator(Nok(fraction1, fraction2), fraction1) - CalculateNumerator(Nok(fraction1, fraction2), fraction2), Nok(fraction1, fraction2));
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denominator * fraction2.Denominator);
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            return fraction1 * new Fraction(fraction2.Denominator, fraction2.Numerator);
        }

        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) == CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) != CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }

        public static bool operator >(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) > CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) < CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }


        public static bool operator >=(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) >= CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }

        public static bool operator <=(Fraction fraction1, Fraction fraction2)
        {
            if (CalculateNumerator(Nok(fraction1, fraction2), fraction1) <= CalculateNumerator(Nok(fraction1, fraction2), fraction2))
            {
                return true;
            }

            return false;
        }

        private static long Nod(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            return a + b;
        }

        private static long Nok(Fraction fraction1, Fraction fraction2)
        {
            return fraction1.Denominator * fraction2.Denominator / Nod(fraction1.Denominator, fraction2.Denominator);
        }

        private static long CalculateNumerator(long nok, Fraction fraction)
        {
            return fraction.Numerator * (nok / fraction.Denominator);
        }
    }
}