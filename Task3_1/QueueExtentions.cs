namespace Task3_1
{
    public static class QueueExtentions
    {
        public static Queue<T> Tail<T>(this IQueue<T> queue)
        {
            if (queue is Queue<T> tailQueue)
            {
                tailQueue.Dequeue();
                return tailQueue;
            }
            else
            {
                throw new InvalidOperationException("Invalid Queue type");
            }
        }
    }
}
