int n = int.Parse(Console.ReadLine());

for (int i = n-1; i >= 0; i--)
{
    string str = new string(' ', i);
    string star = new string('*', n - i);
    Console.WriteLine(str + star);
}