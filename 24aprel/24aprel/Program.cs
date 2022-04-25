using _24aprel.Extensions;
using System;

namespace _24aprel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 90;
            bool check = num.IsEven();
            Console.WriteLine(check);
            int[] array = { 12, 45, 48, 7, 10, 6 };
            foreach (int item in GetValueIndexes(array, 6))
            {
                Console.WriteLine(item);
            }
            int num1 = 43;
            bool check = num1.IsOdd();
            Console.WriteLine(check);
            string str = "p1kk9";
            bool checkChr = str.IsContainsDigit('1');
            Console.WriteLine(checkChr);

            string str1 = "2fffhf9-";
            foreach (char item in GetValueIndexes(str1, 'h'))
            {
                Console.WriteLine(item);
            }

        }
    }
}
