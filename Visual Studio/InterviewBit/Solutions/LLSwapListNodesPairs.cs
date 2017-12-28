using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class LLSwapListNodesPairs
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
            var nodeB = new ListNode(2);
            var nodeC = new ListNode(3);
            var nodeD = new ListNode(4);
            nodeA.next = nodeB;
            nodeB.next = nodeC;
            nodeC.next = nodeD;
            Print(swapPairs(nodeA));
        }

        private void Print(ListNode A)
        {
            while (A != null)
            {
                Console.Write(A.val + " ");
                A = A.next;
            }
        }

        private ListNode swapPairs(ListNode A)
        {            
            if (A == null || A.next == null)
            {
                return A;
            }

            var prev = A;
            var curr = A.next;

            A = curr != null ? curr : A;

            while(true)
            {
                ListNode next = curr.next;
                curr.next = prev;
                
                if (next == null || next.next == null)
                {
                    prev.next = next;
                    break;
                }
                
                prev.next = next.next;

                prev = next;
                curr = prev.next;
            }

            return A;
        }
        


    }


}
