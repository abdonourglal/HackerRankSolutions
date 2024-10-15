namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1 ,1,1,4 ,4 ,4 ,5,5,5, 3 };
            List<int> numbers2 = new List<int> { 1 ,4 ,4 ,1 ,1,1};
            List<int> n = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };




            List<int> birds = new List<int> { 1, 3, 2, 6, 1, 2 };

            divisible_sum_pairs.divisibleSumPairs(6, 3, birds);
            Console.WriteLine("enter value");
            var input = Console.ReadLine();
            Console.WriteLine(input?.RemoveWhiteSpaces().Reverse());

        }
        
    }
}
