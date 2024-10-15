using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp5
{
    class migratory_birds
    {
        List<int> birds = new List<int> { 1, 2, 3, 4, 5 , 4 ,4};
        
       
        public  int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> birdsCount = new Dictionary<int, int>();
            foreach(int bird in arr)
            {
               if(birdsCount.ContainsKey(bird))
                {
                    birdsCount[bird]++;
                }
                else
                {
                    birdsCount[bird] =  1;
                }
            }
            Console.WriteLine("Repeated elements:");
            int maxCount = 0;
            int mostFrequentBird = 0;
            foreach (var bird in birdsCount)
            {
                // If current bird's count is greater than maxCount, update maxCount and bird ID
                // In case of tie (same count), choose the bird with the smaller ID
                if (bird.Value > maxCount || (bird.Value == maxCount && bird.Key < mostFrequentBird))
                {
                    maxCount = bird.Value;
                    mostFrequentBird = bird.Key;
                }
            }
            Console.WriteLine(mostFrequentBird);
            arr.IndexOf(mostFrequentBird);
            Console.WriteLine(arr.IndexOf(mostFrequentBird) + 1);
            return mostFrequentBird;
        }


    }
}
