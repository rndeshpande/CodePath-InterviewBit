using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class TreeInOrderNoRecursion
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

            Print(inorderTraversal(node1));
            
        }

        public void Print(List<int> items)
        {
            foreach(var item in items)
            {
                Console.Write(item + " ");
            }
        }

        public List<int> inorderTraversal(TreeNode A)
        {
            var result = new List<int>();

            var stack = new Stack<TreeNode>();

            var curr = A;
            
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;                
            }

            while(stack.Count > 0)
            {                
                curr = stack.Pop();
                result.Add(curr.val);

                if(curr.right != null)
                {
                    curr = curr.right;
                    while(curr != null)
                    {
                        stack.Push(curr);
                        curr = curr.left;
                    }
                }
            }

            return result;

        }
    }
}
