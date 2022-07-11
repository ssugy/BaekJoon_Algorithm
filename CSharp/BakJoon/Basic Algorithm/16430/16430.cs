int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"{arr[1] - arr[0]} {arr[1]}");