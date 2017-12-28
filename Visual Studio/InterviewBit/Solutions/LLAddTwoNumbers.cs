using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class LLAddTwoNumbers
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { this.val = x; this.next = null; }
        }

        public void Run()
        {
            var node1 = new ListNode(9);
            var node2 = new ListNode(9);
            var node3 = new ListNode(1);
            node1.next = node2;
            node2.next = node3;

            var node4 = new ListNode(1);

            var result = addTwoNumbers(node1, node4);
            Print(result);
        }

        public void Print(ListNode A)
        {
            while(A != null)
            {
                Console.Write(A.val + " ");
                A = A.next;
            }
        }

        public ListNode addTwoNumbers(ListNode A, ListNode B)
        {
            ListNode res = null; 
            ListNode prev = null;
            ListNode temp = null;
            int carry = 0, sum;

            while (A != null || B != null) 
            {                
                sum = carry + (A != null ? A.val : 0)
                        + (B != null ? B.val : 0);
                
                carry = (sum >= 10) ? 1 : 0;

                sum = sum % 10;

                temp = new ListNode(sum);

                if (res == null)
                {
                    res = temp;
                }
                else
                {
                    prev.next = temp;
                }
                
                prev = temp;


                if (A != null)
                {
                    A = A.next;
                }
                if (B != null)
                {
                    B = B.next;
                }
            }

            if (carry > 0)
            {
                temp.next = new ListNode(carry);
            }
            
            return res;

        }
    }
}
