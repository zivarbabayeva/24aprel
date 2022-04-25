using System;
using System.Collections.Generic;
using System.Text;

namespace _24aprel.Extensions
{
    static class ExtensionMethods
    {
       
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static int [] GetValueIndexes(this int[] array, int num)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Array.Resize(ref array, array.Length + 1);
                    array[array.Length - 1] = i;
                }
            }
            return array;
        }
        public static bool IsOdd(this int num1)
        {
            return num1 % 2 == 1;
        }
        public static bool IsContainsDigit(this string str, char digit)
        {
                return str.Contains(digit);    
        }
        public static int[] GetValueIndexes(this string str1, char symbol)
        {
            int[] arr = { };
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == symbol)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                }
            }
            return arr;
        }
    }
}
