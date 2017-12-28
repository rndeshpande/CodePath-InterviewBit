using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week3HkTestSolution2
    {
        public void Run()
        {
            var numOfTests = Convert.ToInt32(Console.ReadLine());
            for(var i=0; i< numOfTests; i++)
            {
                var numOfElems = Convert.ToInt32(Console.ReadLine());
                var elems = Console.ReadLine().Split(' ');

                var list = new List<int>();
                foreach(var elem in elems)
                {
                    list.Add(Convert.ToInt32(elem));
                }

                var result = IsValid(list) ? "YES" : "NO";
                Console.WriteLine(result);
            }
        }

        public bool IsValid(List<int> values)
        {
            var stack = new Stack<int>();

            var min = int.MinValue;
            
            foreach(var value in values)
            {
                if(value < min)
                {
                    return false;
                }
                int temp = int.MinValue;
                while(stack.Count > 0 && value > stack.Peek())
                {
                    temp = stack.Pop();
                }
                min = temp;
                stack.Push(value);
            }

            return true;
        }
    }
}
