/**
 * 시간 : 76ms
 * 이게 웃긴게 그냥 3중for문써서 Console.Wite()해서 하나하나 붙인게 시간이 더 짧음.(64)
 */

int cnt = int.Parse(Console.ReadLine());

for (int i = 0; i < cnt; i++)
{
    string[] str = Console.ReadLine().Split();
    int n = int.Parse(str[0]);
    string resultStr = "";

    for (int j = 0; j < str[1].Length; j++)
    {
        resultStr = resultStr.PadRight(n*(j+1), str[1][j]);
    }
    Console.WriteLine(resultStr);
}