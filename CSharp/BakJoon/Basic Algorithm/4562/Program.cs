// 첫번째 줄은 뒤에 몇 번 반복하냐를 결정함.
int inputFirstStr = int.Parse(Console.ReadLine());

string? inputStr = "";
int num1, num2;

for (int i = 0; i < inputFirstStr; i++)
{
    inputStr = Console.ReadLine();
    num1 = int.Parse(inputStr.Split()[0]);
    num2 = int.Parse(inputStr.Split()[1]);

    if (num1 >= num2)
    {
        Console.WriteLine("MMM BRAINS");
    }
    else
    {
        Console.WriteLine("NO BRAINS");
    }
}