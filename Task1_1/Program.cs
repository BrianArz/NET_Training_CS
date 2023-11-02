using System.Threading.Tasks.Dataflow;

namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = FindDoublesAsNumbers(1, 1700);
            Console.WriteLine("Output: ");
            foreach (var number in output)
            {
                Console.WriteLine(number);
            }
        }

        static List<int> FindDoublesAsNumbers(int start, int end)
        {
            var resultNumbers = new List<int>();
            for (var index = start; index <= end; index++)
            {
                var duodecimalNumber = DecimalBaseToDuodecimalBase(index);
                var counterA = 0;
                foreach (var character in duodecimalNumber)
                {
                    if(character == 'A') counterA++;
                }
                if(counterA == 2) resultNumbers.Add(index);
            }
            return resultNumbers;
        }

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