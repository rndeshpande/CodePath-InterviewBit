using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class MaxSumContiguousSubArray : SolutionBase
    {
        public override void Run()
        {
            var list = new List<int>() { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Print(maxSubArray(list));
            list = new List<int>() { -2, -3};
            Print(maxSubArray(list));
        }

        public int maxSubArray(List<int> A)
        {
            var max = int.MinValue;
            var localMax = 0;

            foreach(var item in A)
            {
                localMax += item;

                max = Math.Max(localMax, max);
                localMax = localMax < 0 ? 0 : localMax;                                
            }

            return max;
        }
    }
}
