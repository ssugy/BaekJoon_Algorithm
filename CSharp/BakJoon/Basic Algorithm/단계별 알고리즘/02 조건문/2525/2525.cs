string str = Console.ReadLine();
int H = int.Parse(str.Split()[0]);
int M = int.Parse(str.Split()[1]);
int C = int.Parse(Console.ReadLine());

int tmp = 0;

M += C;
if (M > 59)
{
    tmp = M / 60;
    M %= 60;
    H += tmp;

    if (H > 23)
    {
        H -= 24;
    }
}

Console.Write($"{H} {M}");

/*
DateTime dt = DateTime.Parse(Console.ReadLine().Replace(' ', ':')).AddMinutes(int.Parse(Console.ReadLine()));
Console.Write("{0} {1}", dt.Hour, dt.Minute);

와.. 이런식으로 시간함수로 쉽게 넘어가는 경우도 있다.
*/