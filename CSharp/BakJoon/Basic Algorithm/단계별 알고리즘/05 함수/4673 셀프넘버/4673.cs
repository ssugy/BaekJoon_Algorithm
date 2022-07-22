// 4673 셀프넘버
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] arr = new int[10001];
int num = 0;
for (int i = 1; i <= 10000; i++)
{
    num = i + i % 10 + (i / 10) % 10 + (i / 100) % 10 + (i / 1000) % 10;    //이게 사실 좋은방법은 아니다. 10000까지라는 전제조건이 있는 것이다.
    if ( num <= 10000)
    {
        arr[num] = 1;
    }
}

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        sw.WriteLine(i);
    }
}

sw.Close();

/**
 static void Main(string[] args)
    {
        bool[] check = new bool[10001];
        for (int i = 1; i < 10001; i++)
        {
            int n = d(i);
            if (n < 10001) check[n] = true;            
        }

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i < 10001; i++)
        {
            if (!check[i])
            {
                sb.Append(i).Append('\n');
            }
        }
        Console.WriteLine(sb);
    }

    static int d(int num)
    {
        int sum = num;
        while(num != 0)
        {
            sum = sum + (num%10);
            num /= 10;
        }
        return sum;
    }
* 
* 이런식으로 작성 할 수 있다. 현재 이게 시간은 가장적다 54ms이다. 내가 작성한 방법은 64ms이다.
*/