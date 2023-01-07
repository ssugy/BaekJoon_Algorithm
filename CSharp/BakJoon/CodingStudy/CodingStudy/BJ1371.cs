using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingStudy
{
    internal class BJ1371
    {
        public static void _Main()
        {
            string sentence = string.Empty;
            int[] chars = new int[28];

            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            // EOF날 때 까지 반복해서 받아야 한다. 아놔 어이가 없네. EOF처리는 null하는데, 우선 string.empty가 안되는게 웃긴거임 진짜.
            //어이가 없네. 그리고 이거는 여기서 테스트로는 할 수 없고, 백준으로 직접 돌려야지 맞는거 알 수 있다.
            while (true)
            {
                string str = sr.ReadLine();
                if (str == null)
                    break;
                sentence += str;
            }

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] >= 97 && sentence[i] <= 122)
                {
                    chars[sentence[i] - 97]++;
                }
            }

            int max = chars.Max();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == max)
                {
                    sw.Write((char)(i + 97));
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
