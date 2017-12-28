using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewBit.Solutions
{
    class Week2HkTestSolution3
    {
        public void Run()
        {            
            Print(firstRepeatedWord("a a"));
            Print(firstRepeatedWord("He had had quite enough of this nonsense"));
            Print(firstRepeatedWord("He had Had quite quite enough of this nonsense"));
            Print(firstRepeatedWord("He had- had quite quite enough of this nonsense"));
        }

        public void Print(string value)
        {
            Console.WriteLine(value);
        }

        public string firstRepeatedWord(string s)
        {
            // Split the sentence into words array per the delimiter list
            // Find all repeated words and store in dictionary
            // Store key as word, index as value
            // Iterate through dictionary and find the minIndex

            var words = s.Split(new string[] { " ", "," , ":" , ";" , "-" , "."}, StringSplitOptions.None);

            // Store 
            var wordFreq = new Dictionary<string,Entry>();

            for(var i=0; i < words.Length; i++)
            {
                var word = words[i];

                if(wordFreq.ContainsKey(word))
                {
                    wordFreq[word].Count++;
                }
                else
                {
                    wordFreq.Add(word, new Entry
                    {
                        Count = 1,
                        Index = i
                    });
                }
            }

            var minIndex = int.MaxValue;
            var result = string.Empty;

            foreach(var kvp in wordFreq)
            {
                if(kvp.Value.Count > 1)
                {
                    if(kvp.Value.Index < minIndex)
                    {
                        minIndex = kvp.Value.Index;
                        result = kvp.Key;
                    }
                }
            }

            return result ;
        }

        class Entry
        {
            public int Count { get; set; }
            public int Index { get; set;}
        }

    }
}
