int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(),int.Parse);
Array.Sort(a);
Console.Write(a[1]);