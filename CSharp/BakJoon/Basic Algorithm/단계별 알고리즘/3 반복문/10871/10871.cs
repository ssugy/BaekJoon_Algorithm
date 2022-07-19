StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string str = Console.ReadLine();
int n = int.Parse(str.Split()[1]);

int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < n)
    {
        sw.Write($"{arr[i]} ");
    }
}

sw.Close();