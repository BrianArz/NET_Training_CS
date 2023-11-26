namespace Task4_1
{
    internal class GenericDiagonalMatrix<T>
    {
        private readonly T[] _mainDiagonal;
        public int Size { get; }

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        public GenericDiagonalMatrix(int size)
        {
            if(size < 0)
                throw new ArgumentException("Matrix size can not be less than 1");

            Size = size;

            _mainDiagonal = new T[Size];
        }

        public T this[int i, int j]
        {
            get
            {
                if (i != j)
                    return default(T);

                if (i < 0 || i >= Size)
                    throw new IndexOutOfRangeException();

                return _mainDiagonal[i];
            }
            set
            {
                if (i == j && (j >= 0 && j < Size))
                {
                    if (!Equals(_mainDiagonal[i], value))
                    {
                        OnElementChanged(new ElementChangedEventArgs<T>(i,  _mainDiagonal[i], value));
                    }
                }
                _mainDiagonal[i] = value;
            }
        }

        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            ElementChanged?.Invoke(this, e);
        }

        public override string ToString()
        {
            var output = "";
            for (var rowIndex = 0; rowIndex < Size; rowIndex++)
            {
                for (var columnIndex = 0; columnIndex < Size; columnIndex++)
                {
                    output += rowIndex == columnIndex ? _mainDiagonal[rowIndex] : 0;
                    output += "\t";
                }

                output += "\n";
            }
            return output;
        }
    }
}
