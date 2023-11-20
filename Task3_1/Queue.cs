namespace Task3_1
{
    internal class Queue<T>: IQueue<T>
    {
        private int _head;
        private int _tail;
        private int _capacity;
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

            for (int index = 0; index < _tail - 1; index++)
            {
                _queue[index] = _queue[index + 1];
            }

            //Second approach where I can get rid of tail item 
            //var newQueue = new T[_capacity];
            //for (int index = 0; index < _tail - 1; index++)
            //{
            //    newQueue[index] = _queue[index + 1];
            //}
            //_queue = newQueue;

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
            for (int index = 0; index < _tail; index++)
            {
                result += "[" + _queue[index] + "]";
            }
            return result;
        }
    }
}
