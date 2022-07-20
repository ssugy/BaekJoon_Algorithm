StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());

string str;
int beforeScore = 0;
int totalScore = 0;
for (int i = 0; i < n; i++)
{
    str = sr.ReadLine();
    foreach (char item in str)
    {
        if (item == 'O')
        {
            beforeScore++;
            totalScore += beforeScore;
        }
        else
        {
            beforeScore = 0;
        }
    }
    sw.WriteLine(totalScore);
    totalScore = 0;
    beforeScore = 0;
}

sr.Close();
sw.Close();

/*
 using System;
using System.Linq;
var N = int.Parse(Console.ReadLine());
for (var i = 0; i < N; i++) { 
    var str = Console.ReadLine().Split('X');
    Console.WriteLine(str.Select(x => x.Length * (x.Length + 1) / 2).Sum());

// 이런식으로 링큐(Select) 써서 해결할 수 있으며, 대신 속도는 68 -> 108까지 올라간다.
}
 */