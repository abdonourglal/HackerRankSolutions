using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     class divisible_sum_pairs
    {
        List<int> birds = new List<int> { 1, 3, 2, 6, 1, 2 };
        public static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int numberOfPairs = 0;
            List<int> repeatd = ar;
            for(int i =0;  i < ar.Count; i++)
            {
                for(int j =i+1;j < ar.Count;j++)
                {
                    if ((ar[i] + repeatd[j]) % k == 0)
                    {
                        numberOfPairs++;
                    }
                  
                }
            }
            Console.WriteLine(numberOfPairs);
            foreach (int f in ar)
            {
                Console.WriteLine(f);
               
            }
            return numberOfPairs;

        }
    }
}
