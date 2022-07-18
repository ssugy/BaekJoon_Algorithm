int t = int.Parse(Console.ReadLine());

string s;
double n = 0;
for (int i = 0; i < t; i++)
{
    s = Console.ReadLine();
    for (int j = 0; j < 24; j++)
    {
        if (s[j].Equals('1'))
        {
            //Console.WriteLine(Math.Pow(2, 4 - j));
            n += Math.Pow(2, 23 - j);
        }
    }
    Console.WriteLine(n);
    n = 0;
}

/**
 * var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
for (int i = 0; i < N; ++i)
{
    string input = sr.ReadLine();
    sw.WriteLine(Convert.ToInt32(input, 2));
}
sr.Close();
sw.Close();

이 코드 참고해볼만 한 것 같음. 스트림으로 값을 처리함.*/