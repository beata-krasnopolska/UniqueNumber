using System;

namespace UniqueNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[3] { 2, 2, 1 };

            var unique = new Finder();
            var uniqueNumber = unique.singleNumber(nums);

            Console.WriteLine(uniqueNumber);
            Console.Read();
        }
    }
}
