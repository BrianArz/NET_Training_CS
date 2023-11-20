namespace Task3_1
{
    public class Queue<T>: IQueue<T>
    {
        private readonly int _head;
        private int _tail;
        private readonly int _capacity;
        private T[] _queue;

        public Queue(int capacity)
        {
            _head = _tail = 0;
            _capacity = capacity;
            _queue = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (_capacity == _tail)
                throw new InvalidOperationException("Queue is full");

            _queue[_tail] = item;
            _tail++;
        }

        public void Dequeue()
        {
            if (_head == _tail)
                throw new InvalidOperationException("Queue is empty");

            var newQueue = new T[_capacity];
            for (var index = 0; index < _tail - 1; index++)
            {
                newQueue[index] = _queue[index + 1];
            }
            _queue = newQueue;

            _tail--;
        }

        public bool IsEmpty()
        {
            return _head == _tail;
        }

        //For testing purposes
        public string PrintQueue()
        {
            var result = "";
            for (var index = 0; index < _tail; index++)
            {
                result += "[" + _queue[index] + "]";
            }
            return result;
        }
    }
}
