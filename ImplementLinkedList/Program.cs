using System;

namespace ImplementLinkedList
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }

        public void Display()
        {
            System.Console.WriteLine(data);

            if (next != null)
            {
                next.Display();
            }
        }
    }

    class SingleLinkedList
    {
        public Node head = null;

        public Node tail = null;

        public void Display()
        {
            if (head == null)
            {
                System.Console.WriteLine("Single Linked List is empty.");
            }
            else
            {   
                head.Display();
            }
        }

        public void InsertFront(int data)
        {
            if (head == null)
            {
                var newNode = new Node(data);

                head = newNode;
                tail = newNode;
            }
            else
            {
                var newNode = new Node(data);

                newNode.next = head;

                head = newNode;
            }
        }

        public void InsertLast(int data)
        {
            if (head == null)
            {
                var newNode = new Node(data);

                head = newNode;
                tail = newNode;
            }
            else
            {
                var newNode = new Node(data);

                tail.next = newNode;
                tail = newNode;
                
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var singleLinkedList = new SingleLinkedList();

            singleLinkedList.InsertFront(4);
            singleLinkedList.InsertLast(3);
            singleLinkedList.InsertLast(7);
            singleLinkedList.InsertFront(9);

            singleLinkedList.Display();
        }
    }
}
