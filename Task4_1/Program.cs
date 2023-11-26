namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test constructor
            var diagonalOne = new GenericDiagonalMatrix<int>(5);
            diagonalOne[0,0] = 1;
            diagonalOne[1,1] = 2;
            diagonalOne[2,2] = 3;
            diagonalOne[3,3] = 4;
            diagonalOne[4,4] = 5;

            var diagonalTwo = new GenericDiagonalMatrix<int>(3);
            diagonalTwo[0, 0] = 6;
            diagonalTwo[1, 1] = 7;
            diagonalTwo[2, 2] = 8;

            //Test size property
            Console.WriteLine($"Diagonal Matrix One Size: {diagonalOne.Size}");

            //Test matix read
            Console.WriteLine($"\nCheck diagonal one read index[3,3] = {diagonalOne[3, 3]}");
            Console.WriteLine($"Check diagonal one read index[3,2] = {diagonalOne[3, 2]}");
            Console.WriteLine($"Check diagonal one read index[7,7] = {diagonalOne[1, 1]}");
            Console.WriteLine($"Check diagonal one read index[-2,-2] = {diagonalOne[3, 2]}");

            //Test Exception
            //diagonalOne[7,7] = 6;

            //Diagonal One
            Console.WriteLine("\nDiagonal Matrix One:");
            //ToString() check
            Console.WriteLine(diagonalOne.ToString());

            //Diagonal Two
            Console.WriteLine("\nDiagonal Matrix Two:");
            //ToString() check
            Console.WriteLine(diagonalTwo.ToString());

            //Test extension method
            var extendedDiagonal = diagonalOne.SumMatrix(diagonalTwo, (a, b) => a + b);
            //Extended
            Console.WriteLine("\nExtended Diagonal:");
            //ToString() check
            Console.WriteLine(extendedDiagonal.ToString());

            //Test Tracker
            var diagonalOneTracker = new GenericMatrixTracker<int>(diagonalOne);

            diagonalOne[4, 4] = 20;
            //Modified Diagonal One
            Console.WriteLine("\nModified Diagonal One:");
            //ToString() check
            Console.WriteLine(diagonalOne.ToString());

            diagonalOneTracker.Undo();
            //Undo check
            Console.WriteLine("\nUndo check:");
            //ToString() check
            Console.WriteLine(diagonalOne.ToString());
        }

        /// <summary>
        /// Prints generic diagonal matrix
        /// </summary>
        /// <typeparam name="T">Define type of diagonal matrix elements</typeparam>
        /// <param name="diagonal">Generic Diagonal Matrix</param>
        private static void PrintMainDiagional<T>(GenericDiagonalMatrix<T> diagonal)
        {
            for (var index = 0; index < diagonal.Size; index++)
            {
                Console.WriteLine($"MainDiagional[{index}][{index}] = {diagonal[index, index]}");
            }
        }
    }
}