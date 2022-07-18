int cnt = int.Parse(Console.ReadLine());

for (int i = 0; i < cnt; i++)
{
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Console.WriteLine(a[0] + a[1]);
}