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
            
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
