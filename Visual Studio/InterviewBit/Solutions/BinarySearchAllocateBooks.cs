using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class BinarySearchAllocateBooks
    {
        public void Run()
        {
            var list = new List<int>() { 12, 34, 67, 90 };
            Print(books(list, 2));
            list = new List<int>() { 97, 26, 12, 67, 10, 33, 79, 49, 79, 21, 67, 72, 93, 36, 85, 45, 28, 91, 94, 57, 1, 53, 8, 44, 68, 90, 24 };
            Print(books(list, 26));

            list = new List<int>() { 31, 14, 19, 75 };
            Print(books(list,12));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public int books(List<int> A,  int B)
        {
            return books(A, A.Count, B);
        }

        public int books(List<int> A, int length, int B)
        {
            var sum = 0;

            if(length < B)
            {
                return -1;
            }

            // Total number of pages
            for(var i=0; i< length;i++)
            {
                sum += A[i];
            }

            var start = 0;
            var end = sum;
            var result = int.MaxValue;

            while(start <= end)
            {
                var mid = (start + end) / 2;

                if (IsPossible(A, length, B, mid))
                {
                    result = Math.Min(result, mid);
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return result;
        }

        private Boolean IsPossible(List<int> A, int length, int B, int min)
        {
            var studentsReq = 1;
            var currSum = 0;

            for(var i=0; i < length; i++)
            {
                if(A[i] > min)
                {
                    return false;
                }

                if(currSum + A[i] > min)
                {
                    studentsReq++;
                    currSum = A[i];
                    if(studentsReq > B)
                    {
                        return false;
                    }
                }
                else
                {
                    currSum += A[i];
                }
            }

            return true;
        }

        public int books1(List<int> A, int B)
        {
            return books(A, B, 0, new Dictionary<string, int>());
        }

        public int books(List<int> A, int B, int startIndex,  Dictionary<string, int> memo)
        {
           
            var key = B + "-" + startIndex;

            if(memo.ContainsKey(key))
            {
                return memo[key];
            }

            if (B > A.Count)
            {
                return -1;
            }
            // Base case: Array with 0 partition
            if (B == 1)
            {
                var sum = 0;
                for(var i = startIndex; i < A.Count; i++)
                {
                    sum += A[i];
                }
                
                memo.Add(key, sum);
                return sum;
            }

            var result = int.MaxValue;
            var currSum = 0;            
            for (var i= startIndex; i < A.Count; i++)
            {
                currSum += A[i];                
                var remainingSum = books(A, B - 1, i+ 1, memo);                
                result = Math.Min(result,  Math.Max(currSum, remainingSum));
            }
            memo.Add(key, result);
            return result;
        }


    }
}
