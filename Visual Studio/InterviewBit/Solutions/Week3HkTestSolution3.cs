using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week3HkTestSolution3
    {
        public void Run()
        {
            //var nums = new int[] { 1, 4, 2, 4 };
            //var maxes = new int[] { 4 };

            var nums = new int[] { 2, 10, 5, 4, 8 };
            var maxes = new int[] { 3, 1, 7, 8 };
            var result = counts(nums, maxes);
            Print(result);
        }

        public void Print(int[] values)
        {
            foreach(var value in values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }


        class Result
        {
            public int Count;
            public int Index;
        }

        int[] counts(int[] nums, int[] maxes)
        {
            var result = new int[maxes.Length];
            Array.Sort(nums);

            var start = 0;
            var end = nums.Length;
            var memo = new Dictionary<int, int>();

            for(var i=0; i< maxes.Length; i++)
            {
                
                if(memo.ContainsKey(maxes[i]))
                {
                    result[i] = memo[maxes[i]];
                }
                else
                {
                    var index = GetCount(nums, maxes[i], start, end);
                    result[i] = index - start;
                    memo.Add(maxes[i], result[i]);
                }
            }
            
            return result;
        }


        int GetCount(int[] nums, int value, int start, int end)
        {
            if (start >= end)
            {
                return start;
            }

            var length = end - start;
            var mid = length / 2;

            if (value < nums[mid])
            {
                return GetCount(nums, value, start, mid);
            }
            else
            {
                return GetCount(nums, value, mid + 1, end);
            }
        }


        int[] counts1(int[] nums, int[] maxes)
        {
            var result = new List<int>();

            Array.Sort(nums);
           
            foreach(var max in maxes)
            {
                var count = GetCount(nums, max, 0, nums.Length);
                result.Add(count);                
            }

            return result.ToArray();
        }

        int GetCount1(int[] nums, int value, int start, int end)
        {
            if(start >= end)
            {
                return start;
            }

            var length = end - start;
            var mid = length / 2;

            if(value < nums[mid])
            {
                return GetCount(nums, value, start, mid);
            }
            else
            {                
                while(mid < end && value >= nums[mid])
                {
                    mid++;                    
                }
                return mid - start;
            }
        }
    }
}
