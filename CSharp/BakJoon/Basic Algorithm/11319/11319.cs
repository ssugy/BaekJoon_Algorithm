int cnt = int.Parse(Console.ReadLine());

string str;
int vowelsCnt = 0;
int consonantsCnt = 0;
for (int i = 0; i < cnt; i++)
{
    str = Console.ReadLine();
    foreach (char a in str)
    {
        if (a != ' ')
        {
            if (a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U' ||
                a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
            {
                vowelsCnt++;
            }
            else
            {
                consonantsCnt++;
            }
        }
    }

    Console.WriteLine(consonantsCnt + " " + vowelsCnt);
    consonantsCnt = 0;
    vowelsCnt = 0;
}