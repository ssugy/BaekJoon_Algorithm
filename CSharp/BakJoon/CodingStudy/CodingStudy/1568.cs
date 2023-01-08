using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class _1568
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int resultCnt = 0;
            int cnt = 1;
            while (a > 0)
            {
                if (a >= cnt)
                {
                    a -= cnt;
                    cnt++;
                }
                else
                {
                    cnt = 1;
                    a -= cnt;
                    cnt++;
                }
                resultCnt++;
            }
            Console.WriteLine(resultCnt);
        }
    }
}
