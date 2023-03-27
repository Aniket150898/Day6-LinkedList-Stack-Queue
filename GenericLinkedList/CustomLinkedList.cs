using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomLinkedList
{
    internal class CustomLinked<T> where T : IComparable<T>
    {
        public Node<T> head;

        internal void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        //displaying the data from linked list
        internal void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }

         }



        public void InsertInDescendingOrder(T value)
        {
            Node<T> newNode = new Node<T>(value);

            // If the list is empty, insert the new node at the head
            if (head == null)
            {
                head = newNode;
                return;
            }

            // If the new node should be the new head, insert it at the beginning
            if (value.CompareTo(head.data) > 0)
            {
                newNode.next = head;
                head = newNode;
                return;
            }
        }
        public void DisplayList()
        {
            Node<T> current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
    }
}
