int a = int.Parse(Console.ReadLine());

int num;
char[] arr;
for (int i = 0; i < a; i++)
{
    num = int.Parse(Console.ReadLine());
    arr = new char[num];
    Array.Fill<char>(arr, '=');
    Console.WriteLine(string.Join("", arr));
}