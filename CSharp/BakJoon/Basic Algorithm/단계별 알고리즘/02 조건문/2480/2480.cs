// 이거 개념을 주사위라는 생각보다, 배열에 주사위 나온걸 넣는 개념으로 생각하자
int[] diceSelected = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] diceNums = new int[7];

diceNums[diceSelected[0]]++;
diceNums[diceSelected[1]]++;
diceNums[diceSelected[2]]++;

int totalPrize = 0;
for (int i = 0; i < 7; i++)
{
    if (diceNums[i] == 3)
    {
        totalPrize = 10000 + i * 1000;
        break;
    }
    else if (diceNums[i] == 2)
    {
        totalPrize = 1000 + i * 100;
        break;
    }
    else if (diceNums[i] == 1)
    {
        totalPrize = 100 * i;
    }
}

Console.Write(totalPrize);