namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var output = CalculateMissingDivisibility(19, 11);
            Console.WriteLine($"Output: {output}");
        }

        static int CalculateMissingDivisibility(int numberA, int numberB)
        {
            var result = numberA % numberB;
            return result != 0 ? numberB - result : 0;
        }
    }
}