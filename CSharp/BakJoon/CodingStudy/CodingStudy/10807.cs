using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class _10807
    {
        public static void _Main()
        {
            Console.ReadLine();
            int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(t.Count(i => i==a));
        }
    }
}
