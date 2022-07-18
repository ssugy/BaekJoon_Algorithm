int cnt = int.Parse(Console.ReadLine());

string tmp;
string name;
int grade = 0;
string gradeString;
for (int i = 0; i < cnt; i++)
{
    tmp = Console.ReadLine();
    name = tmp.Split()[0];
    grade = int.Parse(tmp.Split()[1]);

    switch (grade)
    {
        case >=97:
            gradeString = "A+";
            break;
        case >= 90:
            gradeString = "A";
            break;
        case >= 87:
            gradeString = "B+";
            break;
        case >= 80:
            gradeString = "B";
            break;
        case >= 77:
            gradeString = "C+";
            break;
        case >= 70:
            gradeString = "C";
            break;
        case >= 67:
            gradeString = "D+";
            break;
        case >= 60:
            gradeString = "D";
            break;
        default:
            gradeString = "F";
            break;
    }

    Console.WriteLine($"{name} {gradeString}");
}