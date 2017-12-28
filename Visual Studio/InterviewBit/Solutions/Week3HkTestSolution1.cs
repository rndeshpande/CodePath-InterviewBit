using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week3HkTestSolution1
    {
        public void Run()
        {
            createBST(new int[] { 1, 2, 3 });
        }

        public void Print(int value)
        {
            //Console.WriteLine(value);
        }

        class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
            public Node (int value)
            {
                Value = value;
            }
        }

        void createBST(int[] keys)
        {
            var counter = 0;
            Node root = null;
            foreach (var key in keys)
            {
                if (root == null)
                {
                    root = new Node(key);                    
                }
                else
                {
                    counter = insert(root, key, counter);
                }
                Console.WriteLine(counter);
            }
        }

        int insert (Node node, int key, int counter)
        {
            if(node.Value < key)
            {
                // LST
                if (node.Left == null)
                {
                    node.Left = new Node(key);
                }
                else
                {
                    counter = insert(node.Left, key, counter);
                }
            }
            else
            {
                // LST
                if (node.Right == null)
                {
                    node.Right = new Node(key);
                }
                else
                {
                    counter = insert(node.Right, key, counter);
                }
            }

            return counter +1;
        }
    
    }
}
