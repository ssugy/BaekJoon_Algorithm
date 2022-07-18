var c = Console.ReadLine(); // 이거 여기서는 상관없음.
int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
Console.Write(a.Sum()%3==0?"yes":"no");