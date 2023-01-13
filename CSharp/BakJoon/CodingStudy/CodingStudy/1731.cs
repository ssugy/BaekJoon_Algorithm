using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class _1731
    {
        public static void _Main()
        {
            int MAX = int.Parse(Console.ReadLine());
            int[] arr = new int[MAX];
            int index = 0;
            while (MAX > index)
            {
                arr[index] = int.Parse(Console.ReadLine());
                index++;
            }

            //if (arr[0] * arr[2] == arr[1] * arr[1])
            if ((arr[1] - arr[0]) == (arr[2] - arr[1]))
            {
                Console.WriteLine(arr[MAX - 1] + arr[1] - arr[0]);
            }
            else
            {
                Console.WriteLine(arr[MAX -1] * (arr[1] / arr[0]));
            }
        }
    }
}
