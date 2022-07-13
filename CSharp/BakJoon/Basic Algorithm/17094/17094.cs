StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int inputStringLength = int.Parse(sr.ReadLine());
string str = sr.ReadLine();

int num_2 = str.Count<char>((ch)=>ch=='2'); 
int num_e = str.Count<char>((ch)=>ch=='e');

if (num_2 == num_e)
{
    sw.Write("yee");
}
else
{
    if (num_2 > num_e)
    {
        sw.Write(2);
    }
    else
    {
        sw.Write('e');
    }
}

sr.Close();
sw.Close();