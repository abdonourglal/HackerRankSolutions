using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
     class sock_merchant
    {
        public  int sockMerchant(int n, List<int> ar)
        {
            //Dictionary<int, int> elementCounts = new Dictionary<int, int>();
            //int timesrep = 0;

            //// Loop through the list and count the occurrences of each element
            //foreach (var number in ar)
            //{
            //    if (elementCounts.ContainsKey(number))
            //    {
            //        elementCounts[number]++;  // Increment the count if the element already exists in the dictionary
            //    }
            //    else
            //    {
            //        elementCounts[number] = 1; // Add the element to the dictionary with a count of 1
            //    }
            //}

            //// Print the elements and their counts
            //Console.WriteLine("Element Count: ");
            //foreach (var kvp in elementCounts)
            //{
            //    if (kvp.Value % 2 == 0 )
            //    {

            //        timesrep += kvp.Value;
            //    }
            //    if(kvp.Value > 1 && kvp.Value % 2 != 0)
            //    {
            //        timesrep += kvp.Value - 1;
            //    }

            //    Console.Write(kvp.Value % 2 == 0);
            //    Console.WriteLine($"Element {kvp.Key} occurs {kvp.Value} time(s).");
            //}
            //Console.Write("------------------------- " + timesrep);

            //return timesrep / 2;
            Dictionary<int, int> sockCounts = new Dictionary<int, int>();
            foreach (int i in ar)
            {
                if (sockCounts.ContainsKey(i))
                {
                    sockCounts[i]++;
                }
                else
                {
                    sockCounts[i] = 1;
                }
            }
            int totalPairs = 0;

            // Calculate the number of pairs for each color
            foreach (var kvp in sockCounts)
            {
                totalPairs += kvp.Value / 2;
                Console.WriteLine(kvp.Value);
                Console.WriteLine(kvp.Value / 2);// Divide the count by 2 to get the number of pairs
            }
            Console.WriteLine(totalPairs);
            return totalPairs;
        }
    }
}
