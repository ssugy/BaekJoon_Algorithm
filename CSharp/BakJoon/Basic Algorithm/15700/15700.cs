int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
Console.Write((long)a[0] * a[1]/2);