namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = GetIsbn10("819777048");
            Console.WriteLine($"Output: {output}");
        }

        static string GetIsbn10(string nineDigitString)
        {
            var digitSum = 0;
            var stringCounter = 0;

            for (int index = 10; index >= 2; index--)
            {
                //Numeric representation of a char with - '0'
                var digit = nineDigitString[stringCounter] - '0';
                digitSum += index * digit;
                stringCounter++;
            }

            var checkDigit = CalculateMissingDivisibility(digitSum, 11).ToString();
            if (checkDigit == "10") checkDigit = "X";

            return nineDigitString + checkDigit;
        }

        static int CalculateMissingDivisibility(int numberA, int numberB)
        {
            var result = numberA % numberB;
            return result != 0 ? numberB - result : 0;
        }
    }
}