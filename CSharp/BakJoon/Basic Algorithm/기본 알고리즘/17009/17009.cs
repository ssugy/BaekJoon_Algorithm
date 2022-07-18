/**
 * 원래 StreamReader에서 원하는 읽는 종류를 넣어두면 되는데, new StreamReader(Console.OpenStandardInput()) 이런식으로
 * 근데 이렇게 그냥 쓰면, 내부적으로 콘솔을 계속 열었다 닫았다 하는 불필요한 작업을 하게 된다.
 * 그래서 BufferedStream을 사용해서 콘솔에 들어오는 값을 모두 버퍼에 모았다가 한번 StreamRead하는 방식으로 사용한다.
 * 
 * BufferedStream사용하게 되면, 스트림을 닫는 행위가 같이 이루어져야 한다. 오픈은 그냥 생성해서 사용하는 순간 오픈인데,
 * 닫는건 따로 지정해줘야 한다.
 * 
 * StreamWriter는 ConsoleWriteLine에 대응하는 것이고, 똑같이 중간 BufferedStream들어간다.
 */
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

int[] arr = new int[6];
for (int i = 0; i < 6; i++)
{
    arr[i] = int.Parse(sr.ReadLine());
}

int totalA = arr[0] * 3 + arr[1] * 2 + arr[2];
int totalB = arr[3] * 3 + arr[4] * 2 + arr[5];

if (totalA != totalB)
{
    if (totalA > totalB)
    {
        sw.Write('A');
    }
    else
    {
        sw.Write('B');
    }
}
else
{
    sw.Write('T');
}

sw.Close();
sr.Close();