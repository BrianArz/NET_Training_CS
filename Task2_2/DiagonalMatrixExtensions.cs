namespace Task2_2
{
    internal static class DiagonalMatrixExtensions
    {
        public static DiagonalMatrix SumMatrix(this DiagonalMatrix matrixOne, DiagonalMatrix matrixTwo)
        {
            var maxSize = Math.Max(matrixTwo.Size, matrixOne.Size);
            var extendedMatrix = new int[maxSize];

            for (var index = 0; index < maxSize; index++)
            {
                var firstValue = index < matrixOne.Size ? matrixOne[index, index] : 0;
                var secondValue = index < matrixTwo.Size ? matrixTwo[index, index] : 0;
                extendedMatrix[index] = firstValue + secondValue;
            }

            return new DiagonalMatrix(extendedMatrix);
        }
    }
}
