using System;

namespace LinkedListImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedLinkedList list = new SortedLinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("The ordered list after inserting 56,30,40,70 using sorted linked list is : ");
            list.Display();
        }
    }
}
