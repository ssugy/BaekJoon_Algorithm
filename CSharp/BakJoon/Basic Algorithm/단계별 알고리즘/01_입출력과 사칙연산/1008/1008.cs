double[] a = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
Console.Write(a[0] / a[1]);

// using static System.Console;Write((Read() - Read() * 1.5) / (Read() - 48));
// 여기서 특이한건, 단어 하나씩 가져오는데, 스페이스바의 아스키 코드가 32라서 *1.5 = 48이 된다. 48은 숫자 0이다.