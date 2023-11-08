using System.Diagnostics.CodeAnalysis;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test constructor
            var diagonalOne = new DiagonalMatrix(1, 2, 3, 4, 5);
            var diagonalTwo = new DiagonalMatrix(5, 4, 3, 2, 1);
            //Test on no parameters -> Verified on debug
            var diagonalThree = new DiagonalMatrix();

            //Diagonal One
            Console.WriteLine("Diagonal Matrix One:");
            //ToString() check
            Console.WriteLine(diagonalOne.ToString());
            //Track() check
            Console.WriteLine($"Diagonal One track = {diagonalOne.Track()}");

            //Diagonal Two
            Console.WriteLine("\nDiagonal Matrix Two");
            //ToString() check
            Console.WriteLine(diagonalTwo.ToString());
            //Track() check
            Console.WriteLine($"Diagonal Two track = {diagonalTwo.Track()}");

            //Equals Check
            Console.WriteLine($"\nDiagonal One equals Diagonal Two? = {diagonalOne.Equals(diagonalTwo)}");

            //Read checks
            Console.WriteLine($"\nCheck diagonal one read index[3,3] = {diagonalOne[3, 3]}");
            Console.WriteLine($"Check diagonal one read index[3,2] = {diagonalOne[3, 2]}");
            Console.WriteLine($"Check diagonal one read index[7,7] = {diagonalOne[7, 7]}");
            Console.WriteLine($"Check diagonal one read index[-2,-2] = {diagonalOne[3, 2]}");

            //Modified diagonal one
            diagonalOne[3, 3] = 7;

            //This wont do anything
            diagonalOne[3, 2] = 6;
            diagonalOne[7, 7] = 9;
            diagonalOne[-2, -2] = 10;

            //Write checks
            Console.WriteLine("\nModified Diagonal One:");
            PrintMainDiagional(diagonalOne);

            //Modified Diagonal Two
            diagonalTwo[0, 0] = 1;
            diagonalTwo[1, 1] = 2;
            diagonalTwo[2, 2] = 3;
            diagonalTwo[3, 3] = 7;
            diagonalTwo[4, 4] = 5;

            Console.WriteLine("\nModified Diagonal Two:");
            PrintMainDiagional(diagonalTwo);

            //Equals Check
            Console.WriteLine($"\nDiagonal One equals Diagonal Two? = {diagonalOne.Equals(diagonalTwo)}");
        }

        private static void PrintMainDiagional(DiagonalMatrix diagonal)
        {
            for (var index = 0; index < diagonal.Size; index++)
            {
                Console.WriteLine($"MainDiagional[{index}][{index}] = {diagonal[index, index]}");
            }
        }
    }
}