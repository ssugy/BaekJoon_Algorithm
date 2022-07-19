// 1110번
// 0을 붙이기 전을 주어진 수로 본다.

int firstNum = int.Parse(Console.ReadLine());
int startNum = firstNum;
int nextNum = 0;
int cnt = 0;

while (true)
{
    nextNum = (startNum % 10)*10 + (startNum / 10 + startNum % 10)%10;
    cnt++;
    if (firstNum == nextNum)
    {
        Console.Write(cnt);
        break;
    }

    startNum = nextNum;
}