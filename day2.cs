using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace adventOfCode
{
    public class day2
    {
        private IEnumerable<string> ListOIds { get; set; }

        day2()
        {
            ListOIds = File.ReadAllLines("C:\\Users\\AdamWieckert\\Documents\\QA\\Reday2.txt");
        }
    }
}
