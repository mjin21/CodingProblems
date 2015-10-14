using System;

namespace CodingProblems.DataStructures
{
    public class BST : BinaryTree
    {
        public BST(BTNode root) : base(root)
        {
        }

        public int FindHeight(BTNode node)
        {
            if (node == null)
                //+1 will cause a leaf node will return 1, so need this to balance out
                return -1;

            return Math.Max(FindHeight(node.left), FindHeight(node.right)) + 1;
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
        //Check level
    }
}
