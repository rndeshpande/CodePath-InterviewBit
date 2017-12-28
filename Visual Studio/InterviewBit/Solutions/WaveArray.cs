using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class WaveArray
    {
        public void Run()
        {
            var input = new List<int>() { 1, 2, 3, 4 };
            
            var result = wave(input);
            foreach(var item in result)
            {
                Console.Write(item + " ");
            }
        }

        public List<int> wave(List<int> A)
        {
            A.Sort();
            
            for(var i=0;i< A.Count -1;i+=2)
            {
                var temp = A[i];
                A[i] = A[i + 1];
                A[i + 1] = temp;
            }
            return A;
        }
    }
}
