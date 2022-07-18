/**
 * 연립 방정식 문제는 행렬로 변환해서 풀 수 있고, 
 * 행렬로 변환한 연립방정식의 해를 구하는 방법은
 * 1. 크래머 공식(단순 1차 연립 방정식, 해가 3개 이상 넘어가면 복잡하고 느려짐)
 * 2. 가우스 소거법
 * 이렇게 크게 2가지가 존재한다.
 * 
 * 1) 크래머 공식
 *  ax + by = e
 *  cx + dy = f
 *  
 *  x = | e b |    y = | a e |
 *      | f d |        | c f |
 *      -------        -------
 *      | a b |        | a b |
 *      | c d |        | c d |
 *      
 * 2) 가우스 소거법 - 역삼각형(사다리꼴)로 만든 다음에 밑에서부터 역으로 대입해서 올라가는 방법
 *  - https://datalabbit.tistory.com/28
 */

// 문제는 ax + by = c
//        dx + ey = f 라서 잘 보고 대입해야한다.

int[] a = Array.ConvertAll<string, int>(Console.ReadLine().Split(), int.Parse);
int num = a[0] * a[4] - a[1] * a[3];
Console.Write($"{(a[2] * a[4] - a[1] * a[5]) / num} {(a[0] * a[5] - a[2] * a[3]) / num}");