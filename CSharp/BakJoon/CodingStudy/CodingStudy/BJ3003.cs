using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ3003
    {
        public static void _Main()
        {
            int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
            int[] correctArr = new int[] { 1, 1, 2, 2, 2, 8 };
            int cnt = 0;
            var result = arr.Select((i) => { return correctArr[cnt++] - i; });
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
