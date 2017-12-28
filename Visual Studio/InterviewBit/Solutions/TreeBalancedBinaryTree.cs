using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class TreeBalancedBinaryTree
    {
        public void Run()
        {
            var nodeA1 = new TreeNode(5);
            var nodeA2 = new TreeNode(10);

            nodeA1.left = nodeA2;

            var nodeB1 = new TreeNode(5);

            Print(isBalanced(nodeA1));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public int isBalanced(TreeNode A)
        {
            if (A == null)
            {
                return 1;
            }

            var leftHeight = GetHeight(A.left);
            var rightHeight = GetHeight(A.right);

            if(Math.Abs(leftHeight - rightHeight) <= 1 
                && isBalanced(A.left) > 0
                && isBalanced(A.right) >0 )
            {
                return 1;
            }
            return 0;
        }

        public int GetHeight (TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return 1 + Math.Max(GetHeight(node.left), GetHeight(node.right));
        }
    }
}
