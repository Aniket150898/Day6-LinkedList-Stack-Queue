namespace GenericLinkedQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked Stack Problem!");
            CustomQueue <int> customQueue = new CustomQueue <int>();
            customQueue.Enqueue(10);
            customQueue.Enqueue(20);
            customQueue.Enqueue(30);
            customQueue.Enqueue(40);
            customQueue.Display();

            Console.WriteLine("After DeQueue:-");
            customQueue.Dequeue();
            customQueue.Display();

            Console.ReadKey();
        }
    }
}