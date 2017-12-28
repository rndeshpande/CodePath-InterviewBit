using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class MinCharsMakePalindrome
    {
        public void Run()
        {
            //Print(solve("ABC"));
            //Print(solve(""));
            //Print(solve("AACECAAAA"));
            Print(solve("hqghumeaylnlfdxfi"));
            //Print(solve("abcda"));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }
        
        public int solve(string A)
        {
            if (IsPalindrome(A))
            {
                return 0;
            }

            var inputArr = A.ToCharArray();
            Array.Reverse(inputArr);
            var reverse = new string(inputArr);

            var combined = reverse + A;

            for (int i = 0; i < reverse.Length; i++)
            {
                string prefix = reverse.Substring(0, i + 1);
                
                string newstr = prefix + A;
                
                if (IsPalindrome(newstr))
                {                    
                    int len = newstr.Length - A.Length;
                    return len;
                }
            }

            return A.Length;
        }

        public bool IsPalindrome(String input)
        {
            var inputArr = input.ToCharArray();
            Array.Reverse(inputArr);
            var reverse = new string(inputArr);
            if (reverse.Equals(input))
            {
                return true;
            }
            return false;
        }
    }
}
