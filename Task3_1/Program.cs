namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Queue
            var queue = new Queue<int>(5);
            var secondQueue = new Queue<int>(5);
            var thirdQueue = new Queue<int>(7);

            try
            {
                //Test Enqueue
                queue.Enqueue(1);
                queue.Enqueue(2);
                queue.Enqueue(3);
                queue.Enqueue(4);
                queue.Enqueue(5);
                Console.WriteLine($"First queue: {queue.PrintQueue()}");

                //Test Dequeue
                queue.Dequeue();
                queue.Dequeue();
                Console.WriteLine($"\nFirst queue: {queue.PrintQueue()}");

                //Test IsEmpty
                Console.WriteLine($"\nIs second queue empty? : {secondQueue.IsEmpty()}");

                secondQueue.Enqueue(5);
                Console.WriteLine($"\nIs second queue empty? : {secondQueue.IsEmpty()}");

                //Tail Test
                thirdQueue.Enqueue(1);
                thirdQueue.Enqueue(2);
                thirdQueue.Enqueue(3);
                thirdQueue.Enqueue(4);
                thirdQueue.Enqueue(5);
                thirdQueue.Enqueue(6);
                thirdQueue.Enqueue(7);

                Console.WriteLine($"\nThird queue tail: {thirdQueue.Tail().PrintQueue()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}