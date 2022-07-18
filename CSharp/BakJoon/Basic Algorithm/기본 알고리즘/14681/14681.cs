// -는 45이다.
int q = Console.ReadLine()[0];    
int w = Console.ReadLine()[0];

if (q != 45 )
{
    if (w != 45)
        Console.Write(1);
    else
        Console.Write(4);
}
else
{
    if (w != 45)
        Console.Write(2);
    else
        Console.Write(3);
}