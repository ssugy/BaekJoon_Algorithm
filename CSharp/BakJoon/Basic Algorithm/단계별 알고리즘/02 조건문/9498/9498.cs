//9498
int n = int.Parse(Console.ReadLine());
switch (n)
{
    case int when 90 <= n:
        Console.Write("A");
        break;
    case int when 80 <= n:
        Console.Write("B");
        break;
    case int when 70 <= n:
        Console.Write("C");
        break;
    case int when 60 <= n:
        Console.Write("D");
        break;
    default:
        Console.Write("F");
        break;
}

//Console.Write("FFFFFFDCBAA"[int.Parse(Console.ReadLine())/10]);
// 이건 참신한 방법이다. 