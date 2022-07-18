int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.Write(a[0] * a[1]);

//var s=Console.ReadLine();Console.Write((s[0]-48)*(s[2]-48)); 이런식의 풀이도 존재함. 인풋이 0~9라면 가능함.