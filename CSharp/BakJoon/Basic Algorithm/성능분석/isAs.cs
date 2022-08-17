using System.Diagnostics;

const int Size = 30000000;

/**
 * is와 As를 사용하는 방법이 매우 다양합니다.
 * 그 각각의 방법에 대한 성능 비교를 하는 내용입니다.
 */
object[] values = new object[Size];
for (int i = 0; i < Size - 2; i += 3)
{
    values[i] = null;
    values[i + 1] = "";
    values[i + 2] = 1;
}

FindSumWithIsThenCast(values);

FindSumWithAsThenHasThenValue(values);
FindSumWithAsThenHasThenCast(values);

FindSumWithManualAs(values);
FindSumWithAsThenManualHasThenValue(values);

// 결과 출력
Console.ReadLine();


//// 아래부터는 함수 정의 영역이다.

// is Cast 방식 : 108 ms
static void FindSumWithIsThenCast(object[] values)
{
    Stopwatch sw = Stopwatch.StartNew();
    int sum = 0;
    foreach (object o in values)
    {
        if (o is int)
        {
            int x = (int)o;
            sum += x;
        }
    }
    sw.Stop();
    Console.WriteLine("Is then Cast: {0} : {1}", sum,
                        (long)sw.ElapsedMilliseconds);
}

// As HasValue 방식 : 579 ms
static void FindSumWithAsThenHasThenValue(object[] values)
{
    Stopwatch sw = Stopwatch.StartNew();
    int sum = 0;
    foreach (object o in values)
    {
        int? x = o as int?;

        if (x.HasValue)
        {
            sum += x.Value;
        }
    }
    sw.Stop();
    Console.WriteLine("As then Has then Value: {0} : {1}", sum,
                        (long)sw.ElapsedMilliseconds);
}


// As HasValue Cast 방식 : 569 ms
static void FindSumWithAsThenHasThenCast(object[] values)
{
    Stopwatch sw = Stopwatch.StartNew();
    int sum = 0;
    foreach (object o in values)
    {
        int? x = o as int?;

        if (x.HasValue)
        {
            sum += (int)o;
        }
    }
    sw.Stop();
    Console.WriteLine("As then Has then Cast: {0} : {1}", sum,
                        (long)sw.ElapsedMilliseconds);
}


// 메뉴얼대로한 As방식 : is + 3항연산자cast : 126 ms
static void FindSumWithManualAs(object[] values)
{
    Stopwatch sw = Stopwatch.StartNew();
    int sum = 0;
    foreach (object o in values)
    {
        bool hasValue = o is int;
        int x = hasValue ? (int)o : 0;

        if (hasValue)
        {
            sum += x;
        }
    }
    sw.Stop();
    Console.WriteLine("Manual As: {0} : {1}", sum,
                        (long)sw.ElapsedMilliseconds);
}

// As + null체크 + is 사용 : 577 ms
static void FindSumWithAsThenManualHasThenValue(object[] values)
{
    Stopwatch sw = Stopwatch.StartNew();
    int sum = 0;
    foreach (object o in values)
    {
        int? x = o as int?;

        if (o is int)
        {
            sum += x.Value;
        }
    }
    sw.Stop();
    Console.WriteLine("As then Manual Has then Value: {0} : {1}", sum,
                        (long)sw.ElapsedMilliseconds);
}