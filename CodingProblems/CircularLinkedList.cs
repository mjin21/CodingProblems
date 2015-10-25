using CodingProblems.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class CircularLinkedList
    {
        public bool IsCircular(Node start)
        {
            Node slow = start;
            Node fast = start.Next;

            while(fast != null)
            {
                //Is Circular
                if (slow == fast)
                    return true;
                //Def not circular
                else if (fast.Next == null)
                    return false;

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return false;
        }
    }
}
