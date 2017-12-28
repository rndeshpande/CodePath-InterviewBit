using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class TreeIdenticalBinaryTrees
    {
        public void Run()
        {
            var nodeA1 = new TreeNode(5);
            var nodeA2 = new TreeNode(10);
            
            nodeA1.left = nodeA2;
            
            var nodeB1 = new TreeNode(5);            

            Print(isSameTree(nodeA1, nodeB1));
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

        public int isSameTree(TreeNode A, TreeNode B)
        {
            if (A == null && B == null)
            {
                return 1;
            }

            var valA = A != null ? A.val : int.MinValue;
            var valB = B != null ? B.val : int.MinValue;

            if (valA != valB)
            {
                return 0;
            }
                       
            var leftSame = isSameTree(A.left, B.left) == 1;
            var rightSame = isSameTree(A.right, B.right) == 1;

            return leftSame && rightSame ? 1 : 0;
            
        }

        public int isSameTree1(TreeNode a, TreeNode b)
        {
            if (a == null || b == null)
            {
                return 0;
            }
            
            // Do a BFS on both, check nodes as you go, add null elements to the stack also
            var queueA = new Queue<TreeNode>();
            var queueB = new Queue<TreeNode>();

            queueA.Enqueue(a);
            queueB.Enqueue(b);

            while(queueA.Count > 0 && queueB.Count > 0)
            {
                var nodeA = queueA.Dequeue();
                var nodeB = queueB.Dequeue();

                if (nodeA.val == nodeB.val)
                {
                    if (nodeA.left != null || nodeA.right != null)
                    {
                        queueA.Enqueue(nodeA.left != null ? nodeA.left : new TreeNode(int.MinValue));
                        queueA.Enqueue(nodeA.right != null ? nodeA.right : new TreeNode(int.MinValue));
                    }

                    if (nodeB.left != null || nodeB.right != null)
                    {
                        queueB.Enqueue(nodeB.left != null ? nodeB.left : new TreeNode(int.MinValue));
                        queueB.Enqueue(nodeB.right != null ? nodeB.right : new TreeNode(int.MinValue));
                    }
                }
                else
                {
                    return 0;
                }
            }

            if (queueA.Count != queueB.Count)
            {
                return 0;
            }
            return 1;

        }

    }
}
