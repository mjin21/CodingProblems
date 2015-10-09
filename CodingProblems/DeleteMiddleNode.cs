using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    class DeleteMiddleNode
    {
        public void Delete(LinkedListNode<int> a)
        {
            a.Value = a.Next.Value;
            //a.Next = a.Next.Next;
        }
    }
}
