using System.Diagnostics.CodeAnalysis;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test constructor
            var diagonalOne = new DiagonalMatrix(1, 2, 3, 4, 5);
            Console.WriteLine("Original Main Diagional:");
            PrintMainDiagional(diagonalOne);

            //Read checks
            Console.WriteLine($"\nCheck read index[3,3] = {diagonalOne[3, 3]}");
            Console.WriteLine($"Check read index[3,2] = {diagonalOne[3, 2]}");
            Console.WriteLine($"Check read index[7,7] = {diagonalOne[7, 7]}");
            Console.WriteLine($"Check read index[-2,-2] = {diagonalOne[3, 2]}");

            //Modified diagonal one
            diagonalOne[3, 3] = 7;

            //This wont do anything
            diagonalOne[3, 2] = 6;
            diagonalOne[7, 7] = 9;
            diagonalOne[-2, -2] = 10;

            //Write checks
            Console.WriteLine($"\nModified Main Diagional:");
            PrintMainDiagional(diagonalOne);
        }

        static void PrintMainDiagional(DiagonalMatrix diagonal)
        {
            for (int index = 0; index < diagonal.Size; index++)
            {
                Console.WriteLine($"MainDiagional[{index}][{index}] = {diagonal[index, index]}");
            }
        }
    }
}