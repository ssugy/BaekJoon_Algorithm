StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

string s = sr.ReadLine();
int[] a = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
sw.Write($"{a.Min()} {a.Max()}");

sr.Close();
sw.Close();

/*
이 문제는, streamreader와 writer쓰는게 조금 더 느리다.
입력줄이 2개밖에 없어서 그냥 콘솔 그대로 쓰는게 더 빠르다.
*/