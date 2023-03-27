namespace CustomLinkedStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(30);
            stack.Push(60);
            stack.Push(90);
            stack.Push(120);
            stack.Display();
           
            stack.Pop();
            stack.Display();
            stack.Peek();
            stack.Display();
            stack.isEmpty();
            stack.Display();
            Console.ReadKey();
        }
    }
}