using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    internal class 익명_메소드
    {
        // 이름이 없는 메소드.

        // 익명 메소드를 사용하는 이유

        delegate int Calculate(int a, int b);

        void Test()
        {
            Calculate Calc;

            Calc = delegate (int a, int b)
            {
                return a + b;
            };
        }
    }
}
