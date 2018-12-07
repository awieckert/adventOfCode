using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace adventOfCode
{
    public class day2
    {
        private IEnumerable<string> ListOIds { get; set; }

        public day2()
        {
            ListOIds = File.ReadAllLines("C:\\Users\\AdamWieckert\\Documents\\QA\\day2.txt");
        }

        public string DoASecondThing()
        {
            List<char> letterList = new List<char>();

            for (var i = 0; i < ListOIds.Count(); i++)
            {
                var wordList = ListOIds.ToList();
                var currentWord = wordList[i];
                var wordToReturn = "";

                for (var j = i + 1; j < ListOIds.Count(); j++)
                {
                    var wordToCompare = wordList[j];

                    for (var n = 0; n < wordList[i].Length; n++)
                    {
                        if (currentWord[n] != wordToCompare[n])
                        {
                            letterList.Add(currentWord[n]);
                            letterList.Add(wordToCompare[n]);
                            wordToReturn = currentWord.Remove(n, 1);
                        }
                    }

                    if (letterList.Count == 2)
                    {
                        return wordToReturn;
                    }
                    else
                    {
                        letterList.Clear();
                    }
                }
            }
            return null;
        }

        public int DoAThing()
        {
            var doubles = 0;
            var triples = 0;

            foreach (var word in ListOIds)
            {
                var unique = word.GroupBy(l => l);

                var wordDoubles = 0;

                var wordTriples = 0;

                foreach (var item in unique)
                {
                    if (item.Count() == 2)
                    {
                        wordDoubles++;
                    } 
                    else if (item.Count() == 3)
                    {
                        wordTriples++;
                    }
                }

                if (wordDoubles >= 1)
                {
                    doubles++;
                }

                if (wordTriples >= 1)
                {
                    triples++;
                }
            }

            return doubles * triples;
        }
    }
}
