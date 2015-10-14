using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class Node
    {
        public Node Next;
        public object Value;

        public Node(Node next, object value)
        {
            Next = next;
            Value = value;
        }
    }

    class LinkedList
    {
        public Node Head;
        public Node Tail;

        public LinkedList(Node node)
        {
            Head = node;
            Tail = node;
        }

        void Add(Node node)
        {
            if (Tail != null)
                Tail.Next = node;
        }

        void Remove(int value)
        {
            Node current = Head;
            do
            {
                if (current == null)
                    return;

                if ((int)current.Value == value)
                {
                    current.Value = current.Next.Value;
                    current.Next = current.Next.Next;
                    return;
                }

                current = current.Next;
            } while ((int)current.Value != value);
        }
    }
}
