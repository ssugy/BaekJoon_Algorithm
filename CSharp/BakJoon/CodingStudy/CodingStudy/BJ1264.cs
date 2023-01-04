using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ1264
    {
        public static void _Main()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            string s;
            while ((s = sr.ReadLine())!="#")
            {
                int cnt = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || 
                        s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                    {
                        cnt++;
                    }
                }
                sw.WriteLine(cnt);
            }
            sw.Close();
            sr.Close();
        }
    }
}
