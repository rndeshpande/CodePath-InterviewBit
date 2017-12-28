using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week2HkTestSolution2
    {
        public void Run()
        {
            var node1 = new LinkedListNode();
            node1.val = 3;
            var node2 = new LinkedListNode();
            node2.val = 4;
            var node3 = new LinkedListNode();
            node3.val = 5;
            node1.next = node2;
            node2.next = node3;

            Print(removeNodes(node1, 2));
        }

        public void Print(LinkedListNode node)
        {
            while(node != null)
            {
                Console.Write(node.val + " --> ");
                node = node.next;
            }
        }

        public class LinkedListNode
        {
            public int val;
            public LinkedListNode next;
        }

        public LinkedListNode removeNodes(LinkedListNode list, int x)
        {
            var head = list;

            LinkedListNode prevNode = null;

            while(list != null)
            {
                if(list.val > x)
                {
                    // Delete the node
                    // if first node
                    if (prevNode == null)
                    {
                        head = list.next;
                    }
                    else
                    {
                        prevNode.next = list.next;
                    }                    
                }
                else
                {
                    prevNode = list;
                }
                list = list.next;
            }

            return head;
        }
    }
}
