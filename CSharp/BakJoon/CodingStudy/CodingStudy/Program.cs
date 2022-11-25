using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingStudy
{
    internal class Program
    {
        delegate int CalcDelegate(int x, int y);
        static void _Main(string[] args)
        {
            Calc calc = new Calc();

            int a = 10, b = 20;

            // 델리게이트 +-하기위해서는 메모리 할당먼저 해야된다.
            CalcDelegate calcDelegate = new CalcDelegate(calc.ADD);
            calcDelegate += calc.Sub;
            calcDelegate(10, 5);
        }
    }

    class Calc
    {
        
        public int ADD(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }

        public int Sub(int a, int b)
        {
            Console.WriteLine(a - b);
            return a - b;
        }

        float Div(float a, float b)
        {
            return a / b;
        }
    }
}
