using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.DataStructures.DoubleLinkedList
{
    public class Node
    {
        public Node Previous;
        public Node Next;
        public object Value;

        public Node(Node previous, Node next, object value)
        {
            Previous = previous;
            Next = next;
            Value = value;
        }
    }

    public class DoubleLinkedList
    {
        public Node Head;
        public Node Tail;

        public DoubleLinkedList()
        {
        }

        public DoubleLinkedList(Node node)
        {
            if (Head == null)
                Head = node;
        }

        public void Add(Node node)
        {
            Tail.Next = node;
        }

        public void Remove(Node node)
        {
            Node prev = node.Previous;
            Node next = node.Next;

            prev.Next = next;
            next.Previous = prev;
        }
    }
}
