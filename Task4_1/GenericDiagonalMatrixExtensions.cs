namespace Task4_1
{
    internal static class GenericDiagonalMatrixExtensions
    {
        /// <summary>
        /// Sums two generic diagonal matrix
        /// </summary>
        /// <typeparam name="T">Type of diagonal matrix elements</typeparam>
        /// <param name="matrixOne">First generic diagonal matrix</param>
        /// <param name="matrixTwo">Second generic diagonal matrix</param>
        /// <param name="adder">Delegate function that describes how to add generic diagonal matrix</param>
        /// <returns>Generic Diagonal Matrix</returns>
        public static GenericDiagonalMatrix<T> SumMatrix<T>(this GenericDiagonalMatrix<T> matrixOne, GenericDiagonalMatrix<T> matrixTwo, Func<T, T, T> adder)
        {
            var maxSize = Math.Max(matrixTwo.Size, matrixOne.Size);
            var extendedMatrix = new GenericDiagonalMatrix<T>(maxSize);

            for (var index = 0; index < maxSize; index++)
            {
                var firstValue = index < matrixOne.Size ? matrixOne[index, index] : default;
                var secondValue = index < matrixTwo.Size ? matrixTwo[index, index] : default;
                extendedMatrix[index, index] = adder(firstValue, secondValue);
            }

            return extendedMatrix;
        }
    }
}
