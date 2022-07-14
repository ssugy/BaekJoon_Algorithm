StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

int total = 0;
do
{
    int num = int.Parse(sr.ReadLine());
    if (num == -1)
    { 
        Console.Write(total);
        break;
    }
    else
        total += num;
}while (true);

sr.Close();