int n = int.Parse(Console.ReadLine());
string str;
for (int i = 0; i < n; i++)
{
    str = Console.ReadLine();
    Console.WriteLine(str[0] + str[2] - 96);
}