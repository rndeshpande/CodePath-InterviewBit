using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week2HkTestSolution1
    {
        public void Run()
        {
            var numOfTests = Convert.ToInt32(Console.ReadLine());

            for(var i = 0; i< numOfTests; i++)
            {
                Console.WriteLine(FindMinSubstitutions(Console.ReadLine()));
            }

            Print(FindMinSubstitutions("aaabbb"));
            Print(FindMinSubstitutions("ab"));
            Print(FindMinSubstitutions("abc"));
            Print(FindMinSubstitutions("mnop"));
            Print(FindMinSubstitutions("xyyx"));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public int FindMinSubstitutions(String input)
        {
            var length = input.Length;
            if(length % 2 > 0)
            {
                return -1;
            }

            var strA = input.Substring(0, length / 2);
            var strB = input.Substring(length / 2, length / 2);

            var mapB = new Dictionary<char, int>();

            foreach(var c in strB)
            {
                if(mapB.ContainsKey(c))
                {
                    mapB[c]++;
                }
                else
                {
                    mapB.Add(c, 1);
                }
            }

            var result = 0;

            foreach(var c in strA)
            {
                if(mapB.ContainsKey(c))
                {                   
                    mapB[c]--;    
                    if(mapB[c] == 0)
                    {
                        mapB.Remove(c);
                    }
                }
                else
                {
                    result++;
                }
            }

            return result;
        }
    }
}
