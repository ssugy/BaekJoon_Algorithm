int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.Write(a[0] * (100 - a[1]) >= 10000 ? 0 : 1);