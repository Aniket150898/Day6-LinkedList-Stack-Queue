using CustomLinkedList;

namespace GenericLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem!");
            Console.WriteLine("\n1.CustomLinkedList");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinked<int> customLinked = new CustomLinked<int>();
                    Console.WriteLine("Creating a linked list to add data");
                    customLinked.Add(20);
                    customLinked.Add(30);
                    customLinked.Add(40);
                    customLinked.Display();
                    break;
                    Console.ReadKey();
            }
        }
    }
}