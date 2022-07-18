int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.Write(a.Sum()*5);

/**
 * int a=0;Array.ForEach(Console.ReadLine().Split(),(v)=>a+=int.Parse(v));Console.Write(a*5);
 * 이런식으로 변형도 가능하다.
 * 특이한것은 Array.ForEach로 각각의 요소에 접근해서, 람다식으로 (v) => A+=int.Parse(v)이런식으로
 * 접근해서 처리하는 것이다.
 */