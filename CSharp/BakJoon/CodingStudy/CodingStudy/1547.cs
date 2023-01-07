using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class _1547
    {
        public static void Main()
        {
            // 아스키코드 49(1) 50(2) 51(3)
            char[] arr = new char[3] { '1', '0', '0' };
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                string str = Console.ReadLine();
                Swap(str[0], str[2]);
            }

            string result = new string(arr);
            Console.WriteLine(result.IndexOf('1') + 1);

            void Swap(char v1, char v2)
            {
                int indexA = v1 - 49;
                int indexB = v2 - 49;

                char tmp = arr[indexA];
                arr[indexA] = arr[indexB];
                arr[indexB] = tmp;
            }
        }

    }
}
