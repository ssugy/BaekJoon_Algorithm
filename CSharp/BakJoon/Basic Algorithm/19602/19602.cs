int S = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
int L = int.Parse(Console.ReadLine());

int happyPoint = S + 2*M + 3*L;

if (happyPoint >= 10)
    Console.Write("happy");
else
    Console.Write("sad");