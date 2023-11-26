namespace Task4_1
{
    internal class GenericMatrixTracker<T>
    {
        private GenericDiagonalMatrix<T> _diagonalMatrix;
        private bool _hasLastChange;
        private ElementChangedEventArgs<T> _lastChange;

        public GenericMatrixTracker(GenericDiagonalMatrix<T> diagonalMatrix)
        {
            _diagonalMatrix = diagonalMatrix;
            _diagonalMatrix.ElementChanged += OnElementChanged;
        }

        private void OnElementChanged(object sender, ElementChangedEventArgs<T> e)
        {
            _hasLastChange = true;
            _lastChange = e;
        }

        public void Undo()
        {
            if (_hasLastChange)
            {
                _diagonalMatrix[_lastChange.Row, _lastChange.Column] = _lastChange.OldValue;
                _hasLastChange = false;
            }
        }
    }
}
