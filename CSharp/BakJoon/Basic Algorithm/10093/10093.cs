using System.Text;

string s = Console.ReadLine();
long a = long.Parse(s.Split()[0]);
long b = long.Parse(s.Split()[1]);
long c = (a!=b) ? Math.Abs(a - b) - 1 : 0;

StringBuilder sb = new StringBuilder();

for (int i = 1; i <= c; i++)
{
    if (i != c)
    {
        sb.Append((a >= b) ? i + b : i + a).Append(" ");
    }
    else
    {
        sb.Append((a >= b) ? i + b : i + a);
    }
}

Console.WriteLine(c + "\n" + sb);

/**
 * 문제회고. 해당 문제에서 조건 a == b인경우에 대한 조치를 정확하게 하지 못하고 계속 답이 틀렸다고나와서
 * 답답한 상황으로 감.
 * 이래서 조건을 잘 봐야된다.*/