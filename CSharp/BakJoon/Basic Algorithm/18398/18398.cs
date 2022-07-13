StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int T = int.Parse(sr.ReadLine());

for (int t = 0; t < T; t++)
{
    int N = int.Parse(sr.ReadLine());
    for (int n = 0; n < N; n++)
    {
        int[] arr = Array.ConvertAll<string, int>(sr.ReadLine().Split(), int.Parse);
        sw.WriteLine($"{arr[0] + arr[1]} {arr[0] * arr[1]}");
    }
}

sr.Close();
sw.Close();