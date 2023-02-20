using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class D_1864
    {
        public static void _Main()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str.Equals("#")) { return; }
                double total = 0;
                int selectedNum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    switch (str[str.Length - i - 1])
                    {
                        case '-':
                            selectedNum = 0;
                            break;
                        case '\\':
                            selectedNum = 1;
                            break;
                        case '(':
                            selectedNum = 2;
                            break;
                        case '@':
                            selectedNum = 3;
                            break;
                        case '?':
                            selectedNum = 4;
                            break;
                        case '>':
                            selectedNum = 5;
                            break;
                        case '&':
                            selectedNum = 6;
                            break;
                        case '%':
                            selectedNum = 7;
                            break;
                        case '/':
                            selectedNum = -1;
                            break;
                        default:
                            break;
                    }
                    total += selectedNum * (Math.Pow(8, i));
                }
                Console.WriteLine(total);
            }
        }
    }
}
