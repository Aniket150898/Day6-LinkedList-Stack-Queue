namespace InBuildLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating LinkedList 
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("apple");
            list.AddLast("banana");
            list.AddLast("cherry");
            list.AddLast("date");
            list.AddLast("watermelon");

            //Reading  LinkedList
            Console.Write("Linked list: ");
            foreach (string fruit in list)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // Insert/Updating a new node at the beginning of the list
            list.AddFirst("apricot");
            Console.Write("After adding apricot: ");
            foreach (string fruit in list)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // Remove the node containing "cherry" from the list
            LinkedListNode<string> cherryNode = list.Find("cherry");
            if (cherryNode != null)
            {
                list.Remove(cherryNode);
                Console.Write("After removing cherry: ");
                foreach (string fruit in list)
                {
                    Console.Write(fruit + " ");
                }
                Console.WriteLine();
            }

            // Clear the list
            list.Clear();
            Console.Write("After clearing the list: ");
            foreach (string fruit in list)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}