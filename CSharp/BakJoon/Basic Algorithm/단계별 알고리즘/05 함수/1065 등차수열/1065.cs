//1065 등차수열. 이거 문제 별로 안좋음
// Vacuous truth 에 따라, 전제조건에 해당하는 경우가 아예 존재하지 않으면 전체 조건식은 무조건 참이 됩니다.
//따라서 연속된 항 자체가 없는 수열은 등차수열입니다.

// 그래서 이게 웃긴게, 1부터 99까지는 모두 등차수열이라고 판단하게 됨.
// 3자리수. 즉 100부터 제대로 등차수열 판단을 하는 것임.

int num = int.Parse(Console.ReadLine());
int cnt = 0;

if (num == 1000)
{
    Console.WriteLine(144);
    return;
}

if (num < 100)
{
    Console.WriteLine(num);
}
else 
{
    int a;
    int b;
    int c;
    cnt = 99;
    for (int i = 100; i <= num; i++)
    {
        a = i / 100;
        b = (i / 10) % 10;
        c = i % 10;

        if ((a - b) == (b-c))
        {
            cnt++;
        }
    }
    Console.WriteLine(cnt);
}

/**
int n=int.Parse(Console.ReadLine());
if (n < 100)
{
    Console.WriteLine(n);
}
else
{
    int ans = 99;
    if (n == 1000) n = 999;
    for(int i=100;i<=n;i++)
    {
        if (i % 10 + i / 100 % 10 == i / 10 % 10 * 2) ans++;
    }
    Console.WriteLine(ans);
}

 * 이렇게도 적용이 가능하다. 원리는 등차수열의 경우 처음과 마지막의 합 = 중간값*2와 같다. 이걸로 검색한 것이다.
 * 속도차이는 크지않음. 나는 68나오고 , 이건 64가 나옴. 가장 작은건 60ms이다. 코드는 거의 같음.
 */