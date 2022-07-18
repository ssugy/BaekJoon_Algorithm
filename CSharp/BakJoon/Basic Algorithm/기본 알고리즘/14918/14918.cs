int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
Console.Write(arr[0] + arr[1]);