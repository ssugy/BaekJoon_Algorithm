Console.ReadLine();
int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.Write(a.Average()/a.Max()*100);