using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int cnt = int.Parse(sr.ReadLine());
string[] inputStr;
StringBuilder sb = new StringBuilder();

for (int i = 0; i < cnt; i++)
{
    inputStr = sr.ReadLine().Split();
    for (int j = 0; j < int.Parse(inputStr[0]); j++)
    {
        sb.Append(inputStr[1]);
    }
    sw.WriteLine(sb.ToString());
    sb.Length = 0;
    //sb.Append("\n");// 이 방법이 더 늦음
}

sr.Close();
sw.Close();