using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static  class NumberExtestion
    {
        public static bool IsBetween( this int value , int min , int max)
        {
            return value >= min && value <= max;
        }
    }

}

//>>>>>>>>>>>>>>>>>>>>>>>>>>> PUT THIS CODE IN MAIN CLASS ><<<<<<<<


//Console.WriteLine("enter your precentage");
//int precentage = int.Parse(Console.ReadLine());
//if (precentage.IsBetween(0, 100))
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("Enter valid percentage");
//}