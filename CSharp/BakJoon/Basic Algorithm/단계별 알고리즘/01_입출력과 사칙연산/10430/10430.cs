int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int A = 0;
int B = 0;
int C = 0;
Console.Write($"{(a[0] + a[1]) % a[2]}\n" +
              $"{((a[0] % a[2]) + (a[1] % a[2])) % a[2]}\n" +
              $"{(a[0] * a[1]) % a[2]}\n" +
              $"{((a[0] % a[2]) * (a[1] % a[2]))% a[2]}\n"
              );