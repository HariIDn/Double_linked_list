using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_linked_list
{
    class Node
    {
        /*Node class represent the node of doublu linked list.
         *it consists of the informationpart and links to its
         *succeeding and preceeding
         in terms of next and previous */
        public int noMhs;
        public string name;

        public Node next;

        public Node prev;
    }

    class DoubleLinkedList
    {
        Node START;

        public DoubleLinkedList()
        {
            START = null;
        }
        public void addNode()
        {
            int nim;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnterthe name of the student: ");
            nm = Console.ReadLine();
            Node newNode = new Node();
            newNode.noMhs = nim;
            newNode.name = nm;

            if (START == null || nim == START.noMhs)
            {
                if ((START != null) && (nim == START.noMhs))
                {
                    Console.WriteLine("\nDuplicate number not allowed");
                    return;
                }
                newNode.next = START;
                if (START != null)
                    START.prev = newNode;
                newNode.prev = null;
                START = newNode;
                return;
            }
            //if the node is to be inverted at between two node
            Node previous, current;
            for (current = previous = START;
                current != null && nim >= current.noMhs;
                previous = current, current = current.next)
            {
                if (nim == current.noMhs)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
            }
            newNode.next = current;
            newNode.prev = previous;

            if (current == null)
            {
                newNode.next = current;
                previous.next = newNode;
                return;
            }
            current.prev = newNode;
            previous.next = newNode;
        }
        public bool search(int rollNo, ref Node previous, ref Node current)
        {
            for (previous = current = START; current != null &&
                rollNo != current.noMhs; previous = current,
                current = current.next) { }
            return (current != null);
        }
        public bool dellNode(int rollNo)
        {
            Node previous, current;
            previous = current = null;
            if (search(rollNo, ref previous, ref current) == false)
                return false;
            //teh begining of data
            if (current.next == null)
            {
                previous.next = null;
                return true;
            }
            //node between two nodes in the list
            if (current == START)
            {
                START = START.next;
                if (START != null)
                    START.prev = null;
                return true;
            }
            previous.next = current.next;
            current.next.prev = previous;
            return true;
        }
        public bool listEmpty()
        {
            if (START == null)
                return true;
            else
                return false;
        }
        public void ascending()
        {
            if (listEmpty())
                Console.WriteLine("\nList is Empty");
            else
            {
                Console.WriteLine("\nRecord in the Ascending order of" + "roll number are:\n");
                Node currentNode;
                for (currentNode = START; currentNode != null; currentNode = currentNode.next)
                    Console.Write(currentNode.noMhs + "" + currentNode.name + "\n");
            }
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    } 
}
