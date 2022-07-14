int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
if (a[0] > a[2] + 1 && a[1] > a[3] + 1) Console.Write('1');
else
    Console.Write('0');