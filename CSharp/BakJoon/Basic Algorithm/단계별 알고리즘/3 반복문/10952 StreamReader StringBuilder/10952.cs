StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string s = "";

while (true)
{
    s = sr.ReadLine();

    if (s.Equals("0 0"))
        break;

    sw.WriteLine(s[0] + s[2] - 96);
}

sr.Close();
sw.Close();

// 이 문제를 StreamReader를 이용하는게 아닌, StringBuilder만 사용해도 동일한 속도가 나온다.
// 그러나 StreamReader를 이용하면, StringBuilder보다 더 적은 메모리를 사용한다.
/*
 using System.Text;

StringBuilder sb = new StringBuilder();

while(true)
{   
    int[] t = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int a = t[0] + t[1];
    if (a <= 0)
    {
        break;
    }
    sb.Append(a + "\n");
}

Console.Write(sb);
 */