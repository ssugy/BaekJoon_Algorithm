int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
Console.Write(a[0]*56 + a[1]*24 + a[2]*14 + a[3]*6);