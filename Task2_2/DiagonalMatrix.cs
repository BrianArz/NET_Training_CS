
namespace Task2_2
{
    internal class DiagonalMatrix
    {
        private readonly int[] _mainDiagonal;
        public int Size => _mainDiagonal.Length;

        public DiagonalMatrix(params int[] elements)
        {
            if (elements.Length == 0)
            {
                _mainDiagonal = Array.Empty<int>();
            }
            else
            {
                _mainDiagonal = elements;
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i != j)
                    return 0;
                if (i < 0 || i >= Size)
                    return 0;
                return _mainDiagonal[i];
            }
            set
            {
                if (i == j && (j >= 0 && j < Size))
                    _mainDiagonal[i] = value;
            }
        }

        public int Track()
        {
            var sum = 0;
            for (int index = 0; index < Size; index++)
            {
                sum += _mainDiagonal[index];
            }
            return sum;
        }
    }
}
