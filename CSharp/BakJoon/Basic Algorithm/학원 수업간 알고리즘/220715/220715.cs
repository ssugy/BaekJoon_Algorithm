/**
 * 비트 연산자를 이용해서 1111 0010 이런게 있을 때, 비트 마스크 1111을 지정하고
 * 그 비트마스크로 &연산 한 뒤, 원본 숫자를 오른쪽으로 4비트씩 밀어서 사용하면 된다.
 */


int l = 6517;   // 원래 문제는 이거였다.
string s = Convert.ToString(l, 2).PadLeft(32, '0');
int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;
for (int p = 0; p < 4; p++)
{
    // char의 빼기는 그냥 숫자 빼기, int형변환과 같은 개념
    num1 = (num1 << 1) + s.Substring(16, 4)[p] - '0';
    num2 = (num2 << 1) + s.Substring(20, 4)[p] - '0';
    num3 = (num3 << 1) + s.Substring(24, 4)[p] - '0';
    num4 = (num4 << 1) + s.Substring(28, 4)[p] - '0';
}
Console.WriteLine($"{num1} {num2} {num3} {num4}");
