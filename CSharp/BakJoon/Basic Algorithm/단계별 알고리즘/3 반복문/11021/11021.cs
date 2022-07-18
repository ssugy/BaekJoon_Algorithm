StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
int a = 0;
int b = 0;
string str;

for (int i = 1; i <= n; i++)
{
    str = sr.ReadLine();
    a = int.Parse(str.Split()[0]);
    b = int.Parse(str.Split()[1]);
    sw.WriteLine($"Case #{i}: {a+b}");
}
sr.Close();
sw.Close();