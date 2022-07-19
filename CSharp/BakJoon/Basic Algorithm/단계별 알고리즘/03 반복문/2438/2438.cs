StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        sw.Write('*');
    }
    sw.Write('\n');
}

sr.Close();
sw.Close();

/*
 int score=int.Parse(Console.ReadLine());
for(int i=1;i<=score;i++)
{
Console.WriteLine(new string('*',i));
}

스트링 생성 때, 반복문자열 만들어서 생성 가능하다.
 */