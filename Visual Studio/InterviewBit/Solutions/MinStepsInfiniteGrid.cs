using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class MinStepsInfiniteGrid
    {
        public void Run()
        {
            var listA = new List<int>();
            var listB = new List<int>();

            listA.Add(-7);
            listB.Add(-13);

            listA.Add(1);
            listB.Add(-5);
            
            Console.WriteLine(coverPoints(listA, listB));
        }
        /*
         * 1. Given start and end, find min steps
         * 2. Make start = end, end = next in order
         * 3. Add all min for final result
         *
        */
        public int coverPoints(List<int> A, List<int> B)
        {
            var numOfSteps = 0;

            for(var i=1;i< A.Count;i++)
            {
                numOfSteps += Math.Max(Math.Abs(A[i] -A[i - 1]), Math.Abs(B[i] - B[i - 1]));
            }
            return numOfSteps;
        }        
    }
}
