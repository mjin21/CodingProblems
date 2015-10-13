using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems.Graph
{
    public class Node
    {
        public List<Node> children;
        public object value;

        public Node(List<Node> children, object value)
        {
            this.children = children;
            this.value = value;
        }
    }

    public class Graph
    {
        public void BFSForKevinBacon(Node node, object lookingFor)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            bool found = false;

            int depthCount = 0;
            int childCount = node.children.Count + 1;
            int grandChildCount = 0;
            while (queue.Count > 0)
            {
                Node current = queue.Dequeue();
                childCount--;

                foreach (Node child in current.children)
                {
                    queue.Enqueue(child);
                    if (childCount != 0)
                        grandChildCount++;
                }

                if (childCount == 0)
                {
                    depthCount++;
                    childCount = grandChildCount;
                    grandChildCount = 0;
                }

                if (current.value == lookingFor)
                    found = true;
            }
        }
    }
}
