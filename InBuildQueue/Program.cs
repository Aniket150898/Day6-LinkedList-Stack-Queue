namespace InBuildQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Perfom Inbuild Queue");

            // Create Operation
            Queue<int> intQueue = new Queue<int>();
            
            intQueue.Enqueue(5);
            intQueue.Enqueue(10);
            intQueue.Enqueue(15);
            intQueue.Enqueue(20);
            intQueue.Enqueue(25);

            // Read Operation
            Console.WriteLine("Data in Queue is ");
            foreach (var data in intQueue)
            {
                Console.WriteLine(data);
            }

            //Delete operation
            Console.WriteLine("after Dequeue operation " + intQueue.Dequeue());

            //Peek operation
            Console.WriteLine("Peak Element is " + intQueue.Peek()); 

            Console.WriteLine("Data in Queue after Dequeue is ");
            foreach (var data in intQueue) // print data in queue after all operation
            {
                Console.WriteLine(data);
            }

        }
    }
}