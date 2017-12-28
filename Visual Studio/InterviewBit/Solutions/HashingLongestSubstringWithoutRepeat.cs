using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class HashingLongestSubstringWithoutRepeat
    {
        public void Run()
        {
            Print(lengthOfLongestSubstring("aaaa"));
            Print(lengthOfLongestSubstring("abcd"));
            Print(lengthOfLongestSubstring("abcabcbb"));
            Print(lengthOfLongestSubstring("dadbc"));
        }

        private void Print(int value)
        {
            Console.WriteLine(value);
        }

        public int lengthOfLongestSubstring(string A)
        {            
            /*
             * 1. Start with first character
             * 2. Iterate through remaining characters till a match is found
             * 3. If Match Found: calculate distance between start and repeating and set to maxLength if >
             * 4. If Match not Found: means reached end of string, calculate length from start of loop to string end and set to maxLength if >. Break out of the loo[
             * 5. Return maxLength
             */

            var maxLength = int.MinValue;
            for (var i = 0; i < A.Length; i++)
            {
                var map = new Dictionary<char, int>();
                var foundMatch = false;

                for (var j = i; j < A.Length; j++)
                {
                    if (!map.ContainsKey(A[j]))
                    {
                        map.Add(A[j], 1);
                    }
                    else
                    {
                        var length = j - i;
                        maxLength = Math.Max(maxLength, length);
                        foundMatch = true;
                        break;
                    }
                }

                if(!foundMatch)
                {
                    var length = A.Length - i;
                    maxLength = Math.Max(maxLength, length);
                    break;
                }
            }

            return maxLength ;
        }
    }
}
