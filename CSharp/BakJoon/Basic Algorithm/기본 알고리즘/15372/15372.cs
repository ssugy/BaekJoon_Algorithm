var sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
var sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
int N = int.Parse(sr.ReadLine());
for (int i = 0; i < N; ++i)
{
    int input = int.Parse(sr.ReadLine());
    sw.WriteLine(Math.Pow(input, 2));
}
sr.Close();
sw.Close();

/**
 * 이게 오래걸린 이유
 * 1. StreanReader, StreamWriter 무조건 쓰기.(그냥 cw로 출력하면 오버타임 나온다.)
 * 2. Math안쓰고 제곱하면, 인트제곱이라서 받는데가 long이라도 인트로 나온다. 이게 중요.
 * 그래서 처음부터 long으로 받던지 해야되는데, 그 자체도 별로임. 왜냐면 인트범윈데 롱으로 받아야되서.
 * 3. 영어문제 해석이.. 영어 잘해야될듯.
 * 
 * 아주 겁나 쉬운데 짜증나는 문제였다.*/