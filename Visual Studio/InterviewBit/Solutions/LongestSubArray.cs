using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class LongestSubArray
    {
        public void Run()
        {
            var input = new int[] {3, 1,2, 1};

            Print(maxLength(input, 4));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        static int maxLength(int[] a, int k)
        {
            var maxLength = 0;
            var start = 0;

            var total = 0;

            

            while (start < a.Length)
            {
                var sum = 0;
                for (var j = start; j < a.Length; j++)
                {
                    sum += a[j];
                    var length = j - start + 1;
                    if (sum <= k && length > maxLength)
                    {
                        maxLength = length;
                    }
                    else
                    {
                        sum -= a[start];                        
                    }
                }
                start++;
            }
            return maxLength;
        }
        
    }
}
