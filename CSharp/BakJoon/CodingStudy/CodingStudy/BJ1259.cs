using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ1259
    {
        public static void Main()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string str = sr.ReadLine();
                if (str.Equals("0"))
                    break;

                bool isPalindrome = true;
                for (int i = 0; i < str.Length/2; i++)
                {
                    if (!(str[i].Equals(str[str.Length - i - 1])))
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    sw.WriteLine("yes");
                }
                else
                {
                    sw.WriteLine("no");
                }
            }
            sr.Close();
            sw.Close();

            // 숏코딩 정답 - 와.. 링큐사용이 이렇게 줄어들 수 있구나.
            string s;
            while ((s = Console.ReadLine()) != "0") Console.WriteLine(s.SequenceEqual(s.Reverse()) ? "yes" : "no");
        }
    }
}
