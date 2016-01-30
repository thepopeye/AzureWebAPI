using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcellaApiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new object[2];
            obj[0] = new string[] { "one", "new" };
            obj[1] = new string[] { "not", "net" };
            var ret = PostIsAnagram(obj);
            Console.WriteLine(IsAnagram("parijat", "tajripa"));
            Console.ReadKey();
        }

        public static object PostIsAnagram(object[] value)
        {
            var retarray = new bool[value.Length];
            try
            {
                for (int i = 0; i < value.Length; i++)
                {
                    var arr = value[i] as string[];
                    retarray[i] = IsAnagram(arr[0], arr[1]);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return retarray;
        }

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
    }
}
