using CustomLinkedList;

namespace GenericLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List Problem!");
            Console.WriteLine("\n1.CustomLinkedList \n2.InsertdescendingOrder");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinked<int> customLinked = new CustomLinked<int>();
                    Console.WriteLine("Creating a linked list to add data");
                    customLinked.Add(20);
                    customLinked.Add(30);
                    customLinked.Add(40);
                    customLinked.Add(44);
                    customLinked.Add(54);
                    customLinked.Display();
                    break;
                case 2:
                    CustomLinked<int> deslinklist = new CustomLinked<int>();
                    Console.WriteLine("Creating a linked list to add data");
                    deslinklist.InsertInDescendingOrder(44);
                    deslinklist.InsertInDescendingOrder(55);
                    deslinklist.InsertInDescendingOrder(33);
                    deslinklist.InsertInDescendingOrder(77);
                    deslinklist.DisplayList();
                    break;
                default:
                    Console.WriteLine("Please Enter Valid Option");
                    break;
            }
        }
    }
}