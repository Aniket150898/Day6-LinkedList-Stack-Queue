namespace InBuildStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Performing stack!");

            //creating Stack
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            stack.Push(25);

            //Reading element from the stack
            foreach (int element in stack)
            {
                Console.WriteLine(element);
            }

            //Accessing the top element of the stack 
            int topElement1 = stack.Peek();
            Console.WriteLine("Top of stack element:- " + topElement1);

            //Removing elements from the stack
            int topElement = stack.Pop();

            Console.WriteLine("Remove one element:- " + topElement);

            foreach (int item in stack)
            {
                Console.WriteLine(item + "");
            }

        }
    }
}