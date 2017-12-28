using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class MaxNonNegativeSubArray
    {
        public void Run()
        {
            var input = new List<int>() { 1, 2, -1, 2 };
            //PrintResult(maxset(input));

            //input = new List<int>();
            //PrintResult(maxset(input));

            //input = new List<int>() { 1, -1 };
            //PrintResult(maxset(input));

            //input = new List<int>() {1, 2, -1, 3};
            //PrintResult(maxset(input));

            //input = new List<int>() {-1, 1,2,-1, 2, 1 };
            //PrintResult(maxset(input));

            //input = new List<int>() { -1, -1};
            //PrintResult(maxset(input));

            
            input = new List<int>() { 336465782, -278722862, -2145174067, 1101513929, 1315634022, -1369133069, 1059961393, 628175011, -1131176229, -859484421 };
            PrintResult(maxset(input));
        }

        private void PrintResult(List<int> result)
        {
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public List<int> maxset(List<int> A)
        {            
            var subArrays = new List<List<int>>();

            var start = 0;
            var end = 0;

            var currList = new List<int>();

            // Find all non-negative sub-arrays
            while (end < A.Count)
            {
                if (A[end] < 0)
                {
                    if (end == A.Count -1) // reached the end of the list
                    {
                        break;
                    }
                    start = end + 1;
                    end = start;
                    if(currList.Count > 0)
                    {
                        subArrays.Add(currList);
                    }                    
                    currList = new List<int>();
                    continue;
                }
                currList.Add(A[end]);
                end++;
            }
            if(currList.Count > 0)
            {
                subArrays.Add(currList);
            }

            // Find the sub-array with the highest sum
            long maxSum = int.MinValue;
            var maxLength = int.MinValue;
            var minIndex = int.MaxValue;
            var result = new List<int>();

            foreach(var item in subArrays)
            {
                long sum = 0;
                foreach(var elem in item)
                {
                    sum += elem;
                }

                if(sum > maxSum)
                {
                    maxSum = sum;
                    maxLength = item.Count;
                    minIndex = item[0];
                    result = item;
                }
                else if (sum == maxSum)
                {
                    if(item.Count > maxLength)
                    {
                        result = item;
                        maxLength = item.Count;
                    }
                    else if (item.Count == maxLength)
                    {
                        if(item[0] < minIndex)
                        {
                            minIndex = item[0];
                            result = item;
                        }
                    }
                }
            }
            return result;
        }
    }
}
