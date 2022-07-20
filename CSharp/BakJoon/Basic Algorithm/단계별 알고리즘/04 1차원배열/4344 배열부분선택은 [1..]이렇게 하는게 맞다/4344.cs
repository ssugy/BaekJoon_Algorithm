StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int n = int.Parse(sr.ReadLine());
for (int i = 0; i < n; i++)
{
    int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    arr = arr.Skip(1).ToArray();        // 이거때문에 속도가 74 -> 100으로 올라갔다.이거말고, arr[1..].Average() 이렇게 쓰는게 좋음.
    // 결정적인 차이가 skip해서 배열을 새로 만든거고, 정답은 배열 만들지말고 arr[1..] 이렇게 하면 되는 것이였다.

    Console.WriteLine("{0:F3}%",arr.Count((it) => it > arr.Average())*100.0/arr.Length);
}

sr.Close();
sw.Close();