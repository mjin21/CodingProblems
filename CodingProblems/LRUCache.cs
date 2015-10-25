using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingProblems.DataStructures.DoubleLinkedList;

namespace CodingProblems
{
    class LRUCache
    {
        private static readonly int MAXSIZE = 5;

        //key is the x value, y is the node's value, where order will be maintained by the doubly linked list 
        //Head is oldest, Tail is newest
        private static Dictionary<int, Node> _Cache = new Dictionary<int, Node>();
        private static DoubleLinkedList _TimedList = new DoubleLinkedList();

        public int function(int x)
        {
            int ret = x;
            //if found return y and Update time by removing from list and inserting it to the end
            if(_Cache.ContainsKey(x))
            {
                //remove
                Node prev = _Cache[x].Previous;
                Node next = _Cache[x].Next;
                prev.Next = next;
                next.Previous = prev;

                //add
                Node currentTail = _TimedList.Tail;
                currentTail.Next = _Cache[x];
                _TimedList.Tail = _Cache[x];

                return (int)_Cache[x].Value;
            }

            //if not found check size. if enough room add to end and insert into cache
            //else remove head
            else if(!_Cache.ContainsKey(x))
            {
                if (_Cache.Count == MAXSIZE)
                {
                    _Cache.Remove((int)_TimedList.Head.Value);
                    _TimedList.Head.Next.Previous = null;
                }

                //add
                int y = 5; //i dont wanna solve a function really :/
                Node newNode = new Node(_TimedList.Tail, null, y);

                Node currentTail = _TimedList.Tail;
                currentTail.Next = newNode;
                _TimedList.Tail = newNode;
                _Cache.Add(x, newNode);
            }

            return ret;
        }
    }
}
