namespace Task4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test constructor
            var rationalNumberOne = new RationalNumber(2, 6);
            Console.WriteLine($"Test constructor on 2 / 6 = {rationalNumberOne}");

            //Test Exception
            //var rationalNumberException = new RationalNumber(3, 0);

            //Test Equals
            var rationalNumberTwo = new RationalNumber(4, 12);
            Console.WriteLine($"\nTest equal on 2 / 6 and 4 / 12 = {rationalNumberOne.Equals(rationalNumberTwo)}");

            //Test CompareTo
            var rationalNumberThree = new RationalNumber(1, 2);
            var rationalNumberFour = new RationalNumber(1, 12);
            Console.WriteLine($"\nCompare 2 / 6 to 1 / 2 = {rationalNumberOne.CompareTo(rationalNumberThree)}");
            Console.WriteLine($"\nCompare 2 / 6 to 4 / 12 = {rationalNumberOne.CompareTo(rationalNumberTwo)}");
            Console.WriteLine($"\nCompare 2 / 6 to 1 / 12 = {rationalNumberOne.CompareTo(rationalNumberFour)}");

            //Test +
            Console.WriteLine($"\n2 / 6 + 1 / 2 = {rationalNumberOne + rationalNumberThree}");

            //Test -
            Console.WriteLine($"\n4 / 12 - 1 / 12 = {rationalNumberTwo - rationalNumberFour}");

            //Test *
            Console.WriteLine($"\n1 / 2 * 1 / 2 = {rationalNumberThree * rationalNumberThree}");

            //Test /
            Console.WriteLine($"\n1 / 2 / 1 / 12 = {rationalNumberThree / rationalNumberFour}");

            //Test explicit double cast
            Console.WriteLine($"\nDouble 4 / 12 = {((double)rationalNumberTwo)}");

            //Test implicit int cast
            Console.WriteLine($"\nInt 19 = {((RationalNumber)19)}");
        }
    }
}