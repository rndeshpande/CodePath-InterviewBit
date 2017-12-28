using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class SolutionBase
    {
        public virtual void Run()
        {

        }

        public void Print(int value)
        {
            Console.WriteLine(value);
        }

        public void Print(object[] values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }            
        }

        public void Print(List<Object> values)
        {
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}
