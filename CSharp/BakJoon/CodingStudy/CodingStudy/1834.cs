using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class _1834
    {
        /** 
         * N으로 나누었을 때 나머지와 몫이 같은 모든 자연수의 합을 구하는 프로그램을 작성하시오. 
         * 예를 들어 N=3일 때, 나머지와 몫이 모두 같은 자연수는 4와 8 두 개가 있으므로, 그 합은 12이다.
         * 
         * 이 문제는 정답을 봤음.
         * 이거는 수학적인 접근이 필요하다.
         * 몫과 나머지가 같은 값이라고 가정하고 1부터 n-1인 값들 중에서 찾으면 된다.
         * 안그려면 시간오버 뜬다.
         */
        public static void Main()
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong total = 0;
            for (ulong i = 0; i < n; i++)
            {
                total += (i * n + i);
            }
            Console.WriteLine(total);
        }
    }
}
