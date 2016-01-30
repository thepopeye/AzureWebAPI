using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Methods
{
    public static class Methods
    {
        public static bool IsAnagram(string a, string b)
        {
            var a_chars = a.ToArray();
            Array.Sort(a_chars);
            var b_chars = b.ToArray();
            Array.Sort(b_chars);
            if (a_chars.Length != b_chars.Length) return false;
            bool ret = true;
            for (int i = 0; i < a_chars.Length; i++)
            {
                if (a_chars[i] != b_chars[i])
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }
        
        public static bool IsPalindrome(string a)
        {
            var chars = a.ToArray();
            int len = chars.Length - 1;
            int mid = (chars.Length-1) / 2;
            bool ret = true;
            for (int i = 0; i <= mid; i++)
            {
                if (chars[i] != chars[len - i])
                {
                    ret = false;
                    break;
                }
            }

            return ret;
        }
    }
}