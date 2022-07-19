string s;
do
{
    s = Console.ReadLine();
    if (s == null)
        break;
    
    Console.WriteLine(s[0] + s[2] - 96);
} while (true);

// EOF 처리에 대한 첫번째 문제.