int n = int.Parse(Console.ReadLine());

string result = "";
string tmp;
int cnt = 5;
int tmpCnt;

for (int i = 0; i < n; i++)
{
    tmp = Console.ReadLine();
    tmpCnt = int.Parse(tmp.Split()[1]);
    if ( tmpCnt < cnt)
    {
        cnt = tmpCnt;
        result = tmp.Split()[0];
    }
}

Console.Write(result);