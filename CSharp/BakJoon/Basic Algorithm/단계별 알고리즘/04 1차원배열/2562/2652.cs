StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n;
int max = 0;
int cnt = 0;
for (int i = 1; i < 10; i++)
{
    n = int.Parse(sr.ReadLine());
    if (n > max)
    {
        max = n;
        cnt = i;
    }
}
sw.Write($"{max}\n{cnt}");

sr.Close();
sw.Close();