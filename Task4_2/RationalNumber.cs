namespace Task4_2
{
    internal class RationalNumber : IComparable<RationalNumber>
    {
        private int _numerator;
        private int _denominator;

        public int Numerator => _numerator;
        public int Denominator => _denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator can not be zero");

            int commonDivisor = GreatestCommonDivisor(numerator, denominator);

            _numerator = numerator / commonDivisor;
            _denominator = denominator / commonDivisor;

            if (_denominator < 0)
            {
                _numerator = -_numerator;
                _denominator = -_denominator;
            }
        }

        private int GreatestCommonDivisor(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : GreatestCommonDivisor(b, a % b);
        }

        public override bool Equals(object? obj)
        {
            if (obj is RationalNumber secondRationalNumber)
                return _numerator.Equals(secondRationalNumber.Numerator) && _denominator.Equals(secondRationalNumber.Denominator);

            return false;
        }

        public override string ToString()
        {
            return $"{_numerator} / {_denominator}";
        }

        public int CompareTo(RationalNumber? secondRationalNumber)
        {
            if (secondRationalNumber == null)
                throw new ArgumentException("Object can not be null");

            return (_numerator * secondRationalNumber.Denominator).CompareTo(_denominator * secondRationalNumber.Numerator);
        }

        public static RationalNumber operator +(RationalNumber rationalNumberOne, RationalNumber rationalNumberTwo)
        {
            int numerator = (rationalNumberTwo.Denominator * rationalNumberOne.Numerator) +
                            (rationalNumberOne.Denominator * rationalNumberTwo.Numerator);
            int denominator = rationalNumberOne.Denominator * rationalNumberTwo.Denominator;

            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator -(RationalNumber rationalNumberOne, RationalNumber rationalNumberTwo)
        {
            int numerator = (rationalNumberTwo.Denominator * rationalNumberOne.Numerator) -
                            (rationalNumberOne.Denominator * rationalNumberTwo.Numerator);
            int denominator = rationalNumberOne.Denominator * rationalNumberTwo.Denominator;

            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator *(RationalNumber rationalNumberOne, RationalNumber rationalNumberTwo)
        {
            int numerator = rationalNumberOne.Numerator * rationalNumberTwo.Numerator;
            int denominator = rationalNumberOne.Denominator * rationalNumberTwo.Denominator;

            return new RationalNumber(numerator, denominator);
        }

        public static RationalNumber operator /(RationalNumber rationalNumberOne, RationalNumber rationalNumberTwo)
        {
            int numerator = rationalNumberOne.Numerator * rationalNumberTwo.Denominator;
            int denominator = rationalNumberOne.Denominator * rationalNumberTwo.Numerator;

            return new RationalNumber(numerator, denominator);
        }

        public static explicit operator double(RationalNumber rationalNumber)
        {
            return (double)rationalNumber.Numerator / rationalNumber.Denominator;
        }

        public static implicit operator RationalNumber(int number)
        {
            return new RationalNumber(number, 1);
        }
    }
}
