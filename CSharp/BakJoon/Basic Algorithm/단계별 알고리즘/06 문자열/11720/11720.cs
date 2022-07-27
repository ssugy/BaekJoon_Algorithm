int n = int.Parse(Console.ReadLine());
int t = 0;
for (int i = 0; i < n; i++)
{
    t += Console.Read();
}
Console.Write(t - 48*n);