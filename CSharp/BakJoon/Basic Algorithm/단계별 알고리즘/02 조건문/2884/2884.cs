int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (a[1] - 45 < 0)
{
    a[1] += 15;
    if (a[0] -1 < 0)
    {
        a[0] += 23;
    }
    else
    {
        a[0] -= 1;
    }
}
else
{
    a[1] -= 45;
}

Console.Write($"{a[0]} {a[1]}");

/**
 * string[] inStr = Console.ReadLine().Split(' ');
int H = int.Parse(inStr[0]);
int M = int.Parse(inStr[1]);
M -= 45;
if (M < 0)
{
    M += 60;
    if (--H < 0)H += 24;
}
Console.WriteLine($"{H} {M}");

이렇게 하는게 훨신 깔끔하네. 지금 봐도, 내가 굳이 넣을 필요가 없는 변수의 변경을 넣었음.*/