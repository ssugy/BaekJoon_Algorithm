int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

double distance = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2));
if (distance < a[2] + b[2])
    Console.Write("YES");
else
    Console.Write("NO");

    // 습관적으로 float를 사용하는데, 알고리즘 문제에는 double사용하는게 좋다.