// See https://aka.ms/new-console-template for more information

String? input = Console.ReadLine();

int num1 = int.Parse(input.Split(' ')[0]);
int num2 = int.Parse(input.Split(' ')[1]);

if (num1 > num2)
{
    Console.WriteLine(">");
}else if (num1 == num2)
{
    Console.WriteLine("==");
}
else
{
    Console.WriteLine("<");
}

/*
 * 다른 개발자의 숏코딩
    var a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
    Console.Write(a[0] > a[1] ? ">" : a[0] < a[1] ? "<" : "==");
*/