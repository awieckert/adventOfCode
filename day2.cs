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
