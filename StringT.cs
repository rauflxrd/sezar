using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sezar
{
    internal class @string
    {
        public static string sezar(int K, string s)

        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetter(s[i]))
                    if (char.IsUpper(s[i]))
                    {
                        int a = (s[i] - 64 + K) % 26 + 64;
                        result += (char)a;

                    }
                    else
                    {
                        int A = (s[i] - 96 + K) % 26 + 96;
                        result += (char)A;
                    }
                else
                {
                    result += s[i];
                }

            }
            return result;
        }
    }
}
