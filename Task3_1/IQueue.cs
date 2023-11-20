namespace Task3_1
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        void Dequeue();
        bool IsEmpty();
    }
}
