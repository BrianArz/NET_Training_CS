namespace Task4_1
{
    internal class ElementChangedEventArgs<T> : EventArgs
    {
        public int Row { get; }
        public int Column { get; }
        public T OldValue { get; }
        public T NewValue { get; }

        public ElementChangedEventArgs(int index, T oldValue, T newValue)
        {
            Row = Column = index;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
