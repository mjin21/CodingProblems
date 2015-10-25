using System;
using System.Collections.Generic;

namespace CodingProblems.DataStructures
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
            if (node == null)
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

        public void DFS(BTNode node)
        {
            if (node == null)
                return;

            Stack<BTNode> stack = new Stack<BTNode>();
            stack.Push(node);

            while(stack.Count != 0)
            {
                BTNode current = stack.Pop();
                
                Console.Out.Write(node.value);
                if (node.left != null) stack.Push(current.left);
                if (node.right != null) stack.Push(current.right);
            }
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
                if (node.left != null) queue.Enqueue(current.left);
                if (node.right != null) queue.Enqueue(current.right);
            }
        }


        public bool IsBst(BTNode node)
        {
            if (node == null)
                return true;

            if (node.left != null && (int)node.left.value > (int)node.value)
                return false;

            if (node.right != null && (int)node.right.value < (int)node.value)
                return false;

            if (!IsBST(node.left) || !IsBST(node.right))
                return false;

            return true;
        }
        //Check if BST... How about inorder traversal and checking if its sorted???
        public bool IsBST(BTNode node)
        {
            if (node == null)
                return true;

            if (IsSubTreeLess(node.left, (int)node.value) &&
                IsSubTreeGreater(node.right, (int)node.value) &&
                IsBST(node.left) &&
                IsBST(node.right))
                return true;
            else
                return false;
        }

        private bool IsSubTreeLess(BTNode node, int value)
        {
            if (node == null)
                return true;

            if (value > (int)node.value &&
                IsSubTreeLess(node.left, value) && IsSubTreeLess(node.right, value))
                return true;
            else
                return false;
        }

        private bool IsSubTreeGreater(BTNode node, int value)
        {
            if (node == null)
                return false;

            if (value < (int)node.value &&
                IsSubTreeGreater(node.left, value) && IsSubTreeGreater(node.right, value))
                return true;
            else
                return false;
        }
    }
}
