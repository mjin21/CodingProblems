using CodingProblems.DataStructures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class RemoveDuplicatesLL
    {
        public void Unique(Node node)
        {
            while(node.Next != null)
            {
                Node rabbit = node.Next;
                while (rabbit.Next != null)
                {
                    if (rabbit.Value == rabbit.Next.Value)
                        rabbit.Next = rabbit.Next.Next;
                    else
                    {
                        rabbit = rabbit.Next;
                    }
                }
                node = node.Next;
            }
        }
    }
}
