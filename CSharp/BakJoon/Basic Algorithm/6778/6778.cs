/**
 * 문제
Canada Cosmos Control has received a report of another incident. 
They believe that an alien has illegally entered our space. 
A person who witnessed the appearance of the alien has come forward to describe the alien’s appearance. 
It is your role within the CCC to determine which alien has arrived. 
There are only 3 alien species that we are aware of, described below:

TroyMartian, who has at least 3 antenna and at most 4 eyes;
VladSaturnian, who has at most 6 antenna and at least 2 eyes;
GraemeMercurian, who has at most 2 antenna and at most 3 eyes.

입력
The first line contain the number of antenna that the witness claimed to have seen on the alien. 
The second line contain the number of eyes seen on the alien.
*/

// 숏코딩용 스타일이라서 변수명 등은 최소한으로 설정하였습니다.
int a = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());

if (a >=3 && e <= 4)
    Console.WriteLine("TroyMartian");

if (a <= 6 && e >= 2)
    Console.WriteLine("VladSaturnian");

if (a <= 2 && e <= 3)
    Console.WriteLine("GraemeMercurian");
    