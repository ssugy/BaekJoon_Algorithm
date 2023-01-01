using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ1152
    {
        public static void Main()
        {
            // 내가 제출한 정답
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            string str = sr.ReadLine();
            if (str.Trim() != string.Empty)
            {
                Console.WriteLine(str.Trim().Split().Length);
            }
            else
            {
                Console.WriteLine(0);
            }

            // Trim 처리를 해도, split하면 길이가 1이 나온다.(이건 처음 알았네)
            Console.WriteLine(string.Empty.Split());
            int cnt = 0;
            foreach (var item in Console.ReadLine().Trim().Split())
            {
                Console.WriteLine(item + (cnt++));
            }

            // 숏코딩 정답 - 그냥 Count를 사용하면, 빈칸일경우 정상적인 답이 안나옴 처리가 안됨.
            Console.WriteLine(Console.ReadLine().Split().Count(x => x.Length > 0));
        }
    }
}
