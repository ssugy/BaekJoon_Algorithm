long num = long.Parse(Console.ReadLine());
int cnt = 0;

while (num != 1)
{
    if (num%2 == 0)
        num /= 2;
    else
        num += 1;

    cnt++;
}

Console.Write(cnt);