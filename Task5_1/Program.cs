namespace Task5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test constructor
            SparseMatrix sparseMatrixOne = new SparseMatrix(4, 7);
            sparseMatrixOne[1, 6] = 12;
            sparseMatrixOne[3, 5] = 19;
            sparseMatrixOne[2, 1] = 26;
            sparseMatrixOne[2, 2] = 26;
            sparseMatrixOne[2, 3] = 26;

            // Test toString()
            Console.WriteLine("Sparse Matrix One: ");
            Console.WriteLine(sparseMatrixOne);

            // Test indexer get
            Console.WriteLine($"Value at (2,1) = {sparseMatrixOne[2, 1]}");
            Console.WriteLine($"\nValue at (0,2) = {sparseMatrixOne[0, 2]}");

            // Test idexer set
            sparseMatrixOne[0, 0] = 1;
            Console.WriteLine("\nAdded value at (0,0): ");
            Console.WriteLine(sparseMatrixOne);

            // Test exception out of bounds
            Console.WriteLine($"Value at (8,9); out of bounds");
            try
            {
                Console.WriteLine($"\n{sparseMatrixOne[8, 9]}");
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }

            // Test IEnumerable iteration
            Console.WriteLine($"\nSparse Matrix Values, including 0s:");
            foreach (var number in sparseMatrixOne)
            {
                Console.WriteLine(number);
            }

            // Test GetNonzeroElements()
            Console.WriteLine($"\nSparse Matrix Nonzero elements:");
            foreach (var (row, col, number) in sparseMatrixOne.GetNonzeroElements())
            {
                Console.WriteLine($"Row: {row}, Column: {col}, Number: {number}");
            }

            // Test GetCount
            Console.WriteLine($"\nCounter for 26 = {sparseMatrixOne.GetCount(26)}");
            Console.WriteLine($"\nCounter for 19 = {sparseMatrixOne.GetCount(19)}");
            Console.WriteLine($"\nCounter for 0 = {sparseMatrixOne.GetCount(0)}");

        }
    }
}