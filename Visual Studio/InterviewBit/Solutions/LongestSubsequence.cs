using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class LongestSubsequence
    {
        public void Run()
        {
            Print(longestSubsequence("hackerranks", "hackers"));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        static int longestSubsequence(string x, string y)
        {
            var i = y.Length;
            var maxLength = 0;

            for (int length = y.Length; length > 1; length--)
            {                
                for (int start = 0; start <= y.Length - length; start++)
                {
                    string subString = y.Substring(start, length);
                    
                    if (IsMatch(x, subString))
                    {
                        if (subString.Length > maxLength)
                        {
                            maxLength = subString.Length;
                        }
                    }
                }
            }

            if (maxLength == 0)
            {
                if (IsMatch(x, y[y.Length - 1].ToString()))
                {
                    maxLength = 1;
                }
            }
            
            return maxLength;
        }

        static bool IsMatch(string x, string y)
        {
            var p1 = 0;
            var p2 = 0;

            while(p1 < x.Length && p2 < y.Length)
            {
                if(x[p1] == y[p2])
                {
                    p1++;
                    p2++;
                }
                else
                {
                    p1++;
                }
            }
            return p2 >= y.Length;
        }        
    }
}
