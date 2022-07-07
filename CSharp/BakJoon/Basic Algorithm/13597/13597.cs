int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);

Console.Write(a[0] >= a[1]? a[0]:a[1]);