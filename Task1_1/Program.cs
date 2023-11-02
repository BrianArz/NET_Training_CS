namespace Task1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = DecimalBaseToDuodecimalBase(1999);
            Console.WriteLine($"Output: {output}");
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