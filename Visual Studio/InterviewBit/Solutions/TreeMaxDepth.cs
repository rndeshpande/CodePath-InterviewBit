using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class TreeMaxDepth
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { this.val = x; this.left = this.right = null; }
        }

        public void Run()
        {
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);

            node1.right = node2;
            node2.left = node3;

            Print(maxDepth(node1));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public int maxDepth(TreeNode A)
        {
            if(A == null)
            {
                return 0;
            }

            return 1 + Math.Max(maxDepth(A.left), maxDepth(A.right));
        }
    }
}
