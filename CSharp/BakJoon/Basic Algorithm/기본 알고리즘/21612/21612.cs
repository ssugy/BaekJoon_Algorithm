int n = int.Parse(Console.ReadLine()) * 5 - 400;
Console.WriteLine(n);
switch (n)
{
    case int when n > 100:
        Console.Write("-1");
        break;
    case int when n == 100:
        Console.Write('0');
        break;
    default:
        Console.Write('1');
        break;
}