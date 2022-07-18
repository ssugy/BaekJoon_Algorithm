int[] arr = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);

if (arr[0] + arr[1] + arr[2] >= 100)
{
    Console.Write("OK");
    return;
}

Dictionary<string, int> result = new Dictionary<string, int>();
result.Add("Soongsil", arr[0]);
result.Add("Korea", arr[1]);
result.Add("Hanyang", arr[2]);

result = result.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
Console.WriteLine(result.Keys.First());

/**
 * var dic = new Dictionary<int, string>();
int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
dic[A[0]] = "Soongsil";
dic[A[1]] = "Korea";
dic[A[2]] = "Hanyang";
if (A[0] + A[1] + A[2] >= 100) Console.WriteLine("OK");
else
{
    int n = A.Min();
    Console.WriteLine(dic[n]);
}

// 이런 방식을 사용했어야 한다. dic을 Key val을 바꿨으면 훨신 이렇게 쉽게 풀렸을 것이다.
*/