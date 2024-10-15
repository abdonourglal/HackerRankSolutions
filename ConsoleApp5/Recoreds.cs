using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Recoreds
    {
        public static List<int> breakingRecords(List<int> scores)
        {
            int HighestScore = scores[0];
            int LowestScore = scores[0];
            int BreakInHigh = 0;
            int BreakInLow = 0;
            List<int> res = new List<int>();
            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > HighestScore)
                {
                    HighestScore = scores[i];
                    BreakInHigh++;
                }
                else if (scores[0] < LowestScore)
                {
                    LowestScore = scores[i];
                    BreakInLow ++;
                }

            }


            res.Add(BreakInHigh);
            res.Add(BreakInLow); 
            foreach(int rec in res)
            {
                Console.WriteLine(rec);
            }
            return res;
        }
    }
}
