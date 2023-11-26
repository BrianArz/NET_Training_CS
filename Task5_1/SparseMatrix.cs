using System.Collections;

namespace Task5_1
{
    internal class SparseMatrix : IEnumerable<long>
    {
        private Dictionary<(int, int), long> _sparseMatrix;
        public int Rows { get; }
        public int Columns { get; }

        public SparseMatrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
                throw new ArgumentException("Indices must be greater than zero");

            Rows = rows;
            Columns = columns;
            _sparseMatrix = new Dictionary<(int, int), long>();
        }

        public long this[int i, int j]
        {
            get
            {
                if (i < 0 || i >= Rows || j < 0 || j >= Columns)
                    throw new IndexOutOfRangeException();

                return _sparseMatrix.TryGetValue((i, j), out long value) ? value : 0;
            }
            set
            {
                if (i < 0 || i >= Rows || j < 0 || j >= Columns)
                    throw new IndexOutOfRangeException();

                if(value != 0)
                    _sparseMatrix[(i, j)] = value;
                else
                    _sparseMatrix.Remove((i, j));
            }
        }

        public override string ToString()
        {
            var output = "";
            for (int rowIndex = 0; rowIndex < Rows ; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Columns; columnIndex++)
                {
                    output += (_sparseMatrix.TryGetValue((rowIndex, columnIndex), out long value) ? value : 0).ToString();
                    output += "\t";
                }
                output += "\n";
            }
            return output;
        }

        public IEnumerable<(int, int, long)> GetNonzeroElements()
        {
            for (int rowIndex = 0; rowIndex < Rows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Columns; columnIndex++)
                {
                    if (_sparseMatrix.TryGetValue((rowIndex, columnIndex), out long value))
                        yield return (rowIndex, columnIndex, value);
                }
            }
        }

        public int GetCount(long x)
        {
            int counter = 0;

            if (x == 0)
            {
                counter = (Rows * Columns) - _sparseMatrix.Count;
            }
            else
            {
                foreach (var number in this)
                {
                    if (number == x)
                        counter++;
                }
            }

            return counter;
        }

        public IEnumerator<long> GetEnumerator()
        {
            for (int rowIndex = 0; rowIndex < Rows; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < Columns; columnIndex++)
                {
                    yield return this[rowIndex, columnIndex];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
