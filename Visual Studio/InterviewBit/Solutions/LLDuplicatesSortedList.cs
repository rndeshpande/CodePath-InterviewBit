using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class LLDuplicatesSortedList
    {
        class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { this.val = x; this.next = null; }
        }

        public void Run()
        {
            var nodeA = new ListNode(1);
            var nodeB = new ListNode(1);
            var nodeC = new ListNode(2);
            nodeA.next = nodeB;
            nodeB.next = nodeC;
            Print( deleteDuplicates(nodeA));
        }

        private void Print(ListNode A)
        {
            while(A != null)
            {
                Console.Write(A.val + " ");
                A = A.next;
            }
        }

        private ListNode deleteDuplicates(ListNode A)
        {
            if(A == null || A.next == null)
            {
                return A;
            }

            var currNode = A;

            while(currNode != null)
            {
                if(currNode.next == null)
                {
                    break;
                }
                if (currNode.val == currNode.next.val)
                {
                    currNode.next = currNode.next.next != null ? currNode.next.next : null;
                }
                else
                {
                    currNode = currNode.next;
                }
            }
            return A;
        }

    }
}
