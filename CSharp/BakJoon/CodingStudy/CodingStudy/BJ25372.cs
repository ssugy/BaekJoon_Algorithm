using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ25372
    {
        public static void _Main()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int cnt = int.Parse(sr.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                string str = sr.ReadLine();
                if (str.Length > 5 && str.Length < 10)
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

        }
    }
}
