using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblems
{
    public class BTNode
    {
        public BTNode left;
        public BTNode right;
        public object value;

        public BTNode(BTNode left, BTNode right, int value)
        {
            this.left = left;
            this.right = right;
            this.value = value;
        }
    }

    public class BinaryTree
    {
        public BTNode Root;

        public BinaryTree(BTNode root)
        {
            Root = root;
        }

        public void PreOrderTraversal(BTNode node)
        {
            if(node == null)
                return;
            Console.Out.Write(node.value);
            PreOrderTraversal(node.left);
            PreOrderTraversal(node.right);
        }        
        public void InOrderTraversal(BTNode node)
        {
            if (node == null)
                return;
            InOrderTraversal(node.left);
            Console.Out.Write(node.value);
            InOrderTraversal(node.right);
        }
        public void PostOrderTraversal(BTNode node)
        {
            if (node == null)
                return;
            PostOrderTraversal(node.left);
            PostOrderTraversal(node.right);
            Console.Out.Write(node.value);
        }

        public void BFS(BTNode node)
        {
            if (node == null)
                return;

            Queue<BTNode> queue = new Queue<BTNode>();
            queue.Enqueue(node);
            while (queue.Count != 0)
            {
                BTNode current = queue.Dequeue();

                Console.Out.Write(current.value);
                if (node.left == null) queue.Enqueue(current.left);
                if (node.right == null) queue.Enqueue(current.right);
            }
        }
    }

    public class BST : BinaryTree
    {
        public BST(BTNode root) : base(root)
        {
        }

        public void Insert(int value)
        {
            InsertRec(Root, value);
        }

        public BTNode InsertRec(BTNode node, int value)
        {
            if (node == null)
            {
                node = new BTNode(null, null, value);
                return node;
            }

            if (value < (int)node.value)
                node.left = InsertRec(node.left, value);
            if (value > (int)node.value)
                node.right = InsertRec(node.right, value);

            return node;
        }

        public BTNode Search(BTNode node, int value)
        {
            if ((int)node.value == value)
            {
                return node;
            }

            if (value < (int)node.value)
                Search(node.left, value);
            if (value > (int)node.value)
                Search(node.right, value);

            return null;
        }

        public BTNode FindMin(BTNode node)
        {
            if (node.left == null)
                return node;
            else
                FindMin(node.left);

            return node;
        }

        public BTNode FindMax(BTNode node)
        {
            if (node.right == null)
                return node;
            else
                FindMin(node.right);

            return node;
        }

        public BTNode Delete(BTNode node, int value)
        {
            //Find the value
            if (value < (int)node.value)
                Delete(node.left, value);
            if (value > (int)node.value)
                Delete(node.right, value);

            if ((int)node.value == value)
            {
                //No children
                if (node.left == null && node.right == null)
                    node = null;

                //1 child
                else if (node.left == null)
                {
                    BTNode temp = node.right;
                    node = temp;
                    temp = null;
                }
                else if (node.right == null)
                {
                    BTNode temp = node.left;
                    node = temp;
                    temp = null;
                }

                //2 Children
                else
                {
                    BTNode temp = FindMin(node);
                    node = temp;
                    node.right = Delete(node.right, (int)temp.value);
                }
            }

            return node;
        }
    }
}
