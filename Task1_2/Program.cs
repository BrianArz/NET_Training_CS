namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Asuming that the input has no mistakes, that means:
             * 1. User input a 9 digit string
             */

            Console.WriteLine("Input 9 digit string");
            var nineDigitString = Console.ReadLine();

            var output = GetIsbn10(nineDigitString);
            Console.WriteLine($"\nISBN 10: {output}");
        }

        /// <summary>
        /// Return ISBN 10 for a 9 digit string
        /// </summary>
        /// <param name="nineDigitString"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Returns number that is missing for one number (A) to be multiple of other number (B) 
        /// </summary>
        /// <param name="numberA"></param>
        /// <param name="numberB"></param>
        /// <returns></returns>
        static int CalculateMissingDivisibility(int numberA, int numberB)
        {
            var result = numberA % numberB;
            return result != 0 ? numberB - result : 0;
        }
    }
}