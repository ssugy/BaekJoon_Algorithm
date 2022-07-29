/*
총평
현재 속도는 324라서 속도는 최상급(최상위 1~2등 내)
대신 메모리 사용량이 비슷한 속도 대비 30% 높다.
(메모리 사용양이 높은 이유는 알고리즘이 3 9 27.. 재귀가 이루어질때마다 
배열을 새로 생성해서 그런 것 같기도 하다. 두번째는 string사용. 이렇게 생각하고있다.)
코드량은 일부러 줄이지는 않음. 중간정도 수준

배열의 복사 부분에 대해 많이 알게되었다.
다중배열의 처리를 이렇게 할 수 있으면, ML처리 시에도 C#으로 구현이 쉽게 될 수도 있다는 생각이 듬.
*/
int n = int.Parse(Console.ReadLine());
string[,] str =new string[3, 3] { {"*" , "*" , "*" }
                                , {"*" , " " , "*" }
                                , {"*" , "*" , "*" } };

if (n == 3)
{
    ShowArray(str);
}
else
{
    RecFunc(n, str);
}

static void RecFunc(int depthCnt, string[,] inputStr)
{
    if (depthCnt == 3)
    {
        return;
    }
    int width = inputStr.GetLength(0);
    int height = inputStr.GetLength(1);
    
    string[,] str = new string[inputStr.GetLength(0) * 3 , inputStr.GetLength(1) * 3 ];

    for (int p = 0; p < 3; p++)
    {
        for (int k = 0; k < 3; k++)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (k == 1 && p == 1)
                    {
                        str.SetValue(" ", i + p * width, j + k * width);
                    }
                    else
                    {
                        str.SetValue(inputStr[i, j], i + p*width, j + k*width);
                    }
                }
            }
        }
    }
    depthCnt /= 3;
    RecFunc(depthCnt, str);

    if (depthCnt == 3)
    {
        ShowArray(str);
    }
}

static void ShowArray(string[,] showArray)
{
    StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
    
    for (int i = 0; i < showArray.GetLength(0); i++)
    {
        for (int j = 0; j < showArray.GetLength(1); j++)
        {
            sw.Write(showArray[i,j]);
        }
        sw.WriteLine();
    }
    
    sw.Close();
}

