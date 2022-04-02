using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class ExtentionMethods
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static bool IsContainsDigit(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                foreach (var item in str)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                str =  str.Replace(str[0], char.ToUpper(str[0]));
                return str;
            }
            return null;
        }
        public static int[] GetValueIndexes(this string str, char letter)
        {
            int[] indexes = new int[0];
            if (!string.IsNullOrWhiteSpace(str))
            {
                while (str.Contains(letter))
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = str.LastIndexOf(letter);
                    str = str.Substring(0,str.LastIndexOf(letter));
                }
            }
            Array.Reverse(indexes);
            return indexes;
        }

    }
}
