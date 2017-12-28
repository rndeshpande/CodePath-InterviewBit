using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class AnagramsHashing
    {
        public void Run()
        {
            Print(anagrams(new List<string> { "cat", "dog", "god", "tca", "car" }));
            //Print(anagrams(new List<string> { "abbbaabbbabbbbabababbbbbbbaabaaabbaaababbabbabbaababbbaaabbabaabbaabbabbbbbababbbababbbbaabababba", "abaaabbbabaaabbbbabaabbabaaaababbbbabbbaaaabaababbbbaaaabbbaaaabaabbaaabbaabaaabbabbaaaababbabbaa", "babbabbaaabbbbabaaaabaabaabbbabaabaaabbbbbbabbabababbbabaabaabbaabaabaabbaabbbabaabbbabaaaabbbbab", "bbbabaaabaaaaabaabaaaaaaabbabaaaabbababbabbabbaabbabaaabaabbbabbaabaabaabaaaabbabbabaaababbaababb", "abbbbbbbbbbbbabaabbbbabababaabaabbbababbabbabaaaabaabbabbaaabbaaaabbaabbbbbaaaabaaaaababababaabab", "aabbbbaaabbaabbbbabbbbbaabbababbbbababbbabaabbbbbbababaaaabbbabaabbbbabbbababbbaaabbabaaaabaaaaba", "abbaaababbbabbbbabababbbababbbaaaaabbbbbbaaaabbaaabbbbbbabbabbabbaabbbbaabaabbababbbaabbbaababbaa", "aabaaabaaaaaabbbbaabbabaaaabbaababaaabbabbaaaaababaaabaabbbabbababaabababbaabaababbaabbabbbaaabbb" }));
        }

        private void Print(List<List<int>> result)
        {
            foreach(var item in result)
            {
                foreach(var entry in item)
                {
                    Console.Write(entry + "-");
                }
                Console.Write(" ");
            }
        }


        
        public List<List<int>> anagrams(List<string> A)
        {
        
            var result = new List<List<int>>();
            var map = new Dictionary<string, List<int>>();
            for(var i=0; i< A.Count; i++)
            {
                var valueArr = A[i].ToCharArray();
                Array.Sort(valueArr);
                var key = new String(valueArr);

                if(map.ContainsKey(key))
                {
                    map[key].Add(i+1);
                }
                else
                {
                    map.Add(key, new List<int>() { i+1 });
                }
            }

            foreach(var item in map)
            {                
                result.Add(item.Value);
            }

            return result;
        }        
    }
}
