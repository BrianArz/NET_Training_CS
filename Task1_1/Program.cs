using System.Threading.Tasks.Dataflow;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Assuming the input has no mistakes, that means:
            * 1. User input two numbers
            * 2. Number b is greater that number a
            * 3. User input positive numbers
            */

            Console.WriteLine("Input first number: (a)");
            var inputA = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInput second number (b)");
            var inputB = int.Parse(Console.ReadLine());

            var output = FindDoublesAsNumbers(inputA, inputB);
            Console.WriteLine("\nOutput: ");
            foreach (var number in output)
            {
                Console.WriteLine(number);
            }
        }


        /// <summary>
        /// Returns a int array with all the numbers between a range that contains exactly two 'A' on their duodecimal representation
        /// </summary>
        /// <param name="start">Begining of the range</param>
        /// <param name="end">Ending of the range</param>
        /// <returns></returns>
        static int[] FindDoublesAsNumbers(int start, int end)
        {
            var tempArray = new int[end - start + 1];
            var count = 0;

            for (var index = start; index <= end; index++)
            {
                var duodecimalNumber = DecimalBaseToDuodecimalBase(index);
                var counterA = 0;
                foreach (var character in duodecimalNumber)
                {
                    if(character == 'A') counterA++;
                }

                if (counterA == 2)
                {
                    tempArray[count] = index;
                    count++;
                }
            }

            var resultArray = new int[count];
            Array.Copy(tempArray, resultArray, count);
            
            return resultArray;
        }

        /// <summary>
        /// Return duodecimal representation (string) of a decimal number
        /// </summary>
        /// <param name="decimalNumber">Decimal number to convert</param>
        /// <returns></returns>
        static string DecimalBaseToDuodecimalBase(int decimalNumber)
        {
            const string duodecimalSymbols = "0123456789AB";

            if (decimalNumber == 0) 
                return "0";

            var duodecimalNumber = "";

            while (decimalNumber > 0)
            {
                duodecimalNumber = duodecimalSymbols[decimalNumber % 12] + duodecimalNumber;
                decimalNumber /= 12;
            }

            return duodecimalNumber;
        }
    }
}