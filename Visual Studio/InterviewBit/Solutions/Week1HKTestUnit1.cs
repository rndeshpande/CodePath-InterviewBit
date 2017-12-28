using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week1HKTestUnit1
    {
        public void Run()
        {
            Print(summation(null));
        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        static int summation(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
