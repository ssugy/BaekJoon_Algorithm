/**
 * 문제
두 양의 정수가 주어졌을 때, 첫 번째 수가 두 번째 수보다 큰지 구하는 프로그램을 작성하시오.

입력
입력은 여러 개의 테스트 케이스로 이루어져 있다. 각 테스트 케이스는 한 줄로 이루어져 있으며, 두 정수가 주어진다. 두 수는 백만보다 작거나 같은 양의 정수이다. 입력의 마지막 줄에는 0이 두 개 주어진다.

출력
각 테스트 케이스마다, 첫 번째 수가 두 번째 수보다 크면 Yes를, 아니면 No를 한 줄에 하나씩 출력한다.
*/

int num1 = -1;
int num2 = -1;

while (num1 != 0 || num2 != 0)
{
    string? inputStr = Console.ReadLine();  // 널이 나올수 없는데 널이야기를 하는게 이해가 안가긴한다.
    num1 = int.Parse(inputStr.Split()[0]);
    num2 = int.Parse(inputStr.Split()[1]);

    if (num1 ==0 && num2 ==0)
    {
        break;
    }

    if (num1 > num2)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}