int[] a = new int[42];
for (int i = 0; i < 10; i++)
{
    a[int.Parse(Console.ReadLine())%42] = 1;
}
Console.Write(a.Sum());