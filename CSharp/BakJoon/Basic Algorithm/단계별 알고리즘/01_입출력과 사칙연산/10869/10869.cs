int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.Write($"{a[0] + a[1]}\n{a[0] - a[1]}\n{a[0] * a[1]}\n{a[0] / a[1]}\n{a[0] % a[1]}");