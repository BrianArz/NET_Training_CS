namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test Queue
            Queue<int> queue = new Queue<int>(5);
            Queue<int> secondQueue = new Queue<int>(5);
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

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}