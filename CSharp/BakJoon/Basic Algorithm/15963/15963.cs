long[] arr = Array.ConvertAll<string, long>(Console.ReadLine().Split(), long.Parse);
if (arr[0] == arr[1])
    Console.Write(1);
else
    Console.Write(0);

/*
var s = Console.ReadLine().Split();
Console.WriteLine(s[0] == s[1] ? 1 : 0);

 // 이런식으로 var을 사용하는 것 long형 배열로 자동 변환된다.*/