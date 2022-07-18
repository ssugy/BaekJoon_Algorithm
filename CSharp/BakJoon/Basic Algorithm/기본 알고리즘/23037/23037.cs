using System.Globalization;

string str = Console.ReadLine();
double result = 0;
for (int i = 0; i < 5; i++)
{
    result += Math.Pow(CharUnicodeInfo.GetDecimalDigitValue(str[i]), 5);
}

Console.Write(result);

// char을 int로 변환하는 것.