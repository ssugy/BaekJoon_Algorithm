int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());

string str = (n1 * n2 * n3).ToString();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(str.Count((a)=>a-48==i));
}

// 스트링에 char를 람다식으로 계산해서 처리.
// 속도는 64로 괜찮게 나온다.