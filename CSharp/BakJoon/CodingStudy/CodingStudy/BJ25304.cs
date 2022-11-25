using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ25304
    {
        public static void Main()
        {
            var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
            int totalPrice = int.Parse(sr.ReadLine());
            int cnt = int.Parse(sr.ReadLine());
            for (int i = 0; i < cnt; i++)
            {
                string price = sr.ReadLine();
                totalPrice -= (int.Parse(price.Split()[0]) * int.Parse(price.Split()[1]));
            }

            if (totalPrice == 0)
                sw.Write("Yes");
            else
                sw.Write("No");
            sr.Close();
            sw.Close();
        }
    }
}
