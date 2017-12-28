using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week2HkTestSolution4
    {
        public void Run()
        {
            var a = new int[] { 1, 2, 3, 4, 5 };
            //var a = new int[] { 5, 4 , 3, 2, 1 };

            Sort(a);
        }

        public static int[] insertionSort(int[] a)
        {
            var count = 0;
            for(var i = 1; i < a.Length; i++)
            {
                var temp = a[i];
                Console.Write(i + " - ");
                for(var j= i-1; j > -1; j--)
                {
                    
                    if (temp < a[j])
                    {
                        count++;
                        Console.Write(count + " ");
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }

                Console.WriteLine();
            }

            return a;
        }


        public static int[] Sort(int[] a)
        {
            var count = 0;
            for (var i = 1; i < a.Length -2; i++)
            {                
                Console.Write(i + " - ");
                for (var j = 0; j < a.Length - i -1; j++)
                {
                    count++;
                    Console.Write(count + " ");
                    if (a[j] > a[j+ 1])
                    {
                        
                        int temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }

                Console.WriteLine();
            }

            return a;
        }
    }
}
