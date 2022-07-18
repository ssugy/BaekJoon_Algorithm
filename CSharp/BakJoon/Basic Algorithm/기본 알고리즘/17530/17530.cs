StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

int cnt = int.Parse(sr.ReadLine());
int carlos = int.Parse(sr.ReadLine());
for (int i = 0; i < cnt - 1; i++)
{
    if (int.Parse(sr.ReadLine()) > carlos)
    {
        Console.Write('N');
        sr.Close();
        return;
    }
}

Console.Write('S');
sr.Close();