List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var rnd = new Random();
// 시간으로 변경하기에는, 시간이 단방향 증가라서 섞이지 않는다. 그리고 중첩 시간도 많다.
//var randomized = list1.OrderBy(item => {Console.WriteLine(DateTime.Now.Millisecond); return DateTime.Now.Millisecond; });

// 셔플하는방법 1 - 이렇게 람다식 사용
//var randomized = list1.OrderBy(item => rnd.Next());

// 셔플하는방법 2 - 람다식을 더 줄이기. OrderBy안에 들어가는 값이, 함수 원형이 들어가야된다. 그래서 rnd.Next()이 아니라 rnd.Next이다.
var randomized = list1.OrderBy(rnd.Next);

int cnt = 0;
// 로그를 확인 할 수 있으며, 이렇게 확인하는 경우, 배열의 갯수만큼 반복하는 사실을 확인 할 수 있다.
list1.OrderBy(item => { Console.WriteLine(cnt++); return rnd.Next(); });

foreach (var value in randomized)
{
    Console.WriteLine(value);
}