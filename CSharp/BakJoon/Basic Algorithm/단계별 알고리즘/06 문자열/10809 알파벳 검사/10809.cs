/**
 * 시간 : 84ms
 * 내가 생각을 좀 더 확장해야 되는게, 
 * 보자마자 배열을 써야되겠다. 이렇게 생각해서 배열처리에 관한 이것저것이 들어가면서 느려진 것이다.
 */
string s = Console.ReadLine();
int[] a = Enumerable.Repeat(-1, 26).ToArray();
for (int i = 0; i < 26; i++)
{
    char c = (char)(97 + i);
    if (s.Contains(c))
        a[i] = s.IndexOf(c);
}
// 배열 일괄출력 방법 1번 string.join사용
Console.Write(String.Join(" ", a));

// 배열 일괄출력 방법 2번 Array.ForEach사용
//Array.ForEach(arr, i => Console.Write(i + " "));

/* 
 * 시간 : 64ms
 * 배열 안쓰고 처리한 케이스. 이게 좋은 것 같음.

string word = Console.ReadLine();
for (int i = 97; i < 123; i++)
{
    Console.Write(word.IndexOf(Convert.ToChar(i)) + " ");
}
 */