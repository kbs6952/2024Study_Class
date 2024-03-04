using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class Mutable_Type_and_Immutable_Type
    {
        // 데이터 값 타입 vs 참조 타입 
        // 메모리가 작은 타입은 값 타입으로 C#이 놓음 -> int, double, float .....
        // 메모리가 상대적 클 것이라고 생각되는 타입들은 참조 타입으로 정해졌다. -> class, delegate, string

        // 가변 객체 Mutable Type

        // 불변 객체 Immutable Type

        void Example()
        {
            int num = 3;
            num = 4;

            string a = "AA";
            a = "BB";
            a += "C";

            Console.WriteLine(a);

            // 스레드 Thread 
            // 동기 프로그래밍 비동기 프로그래밍
        }

        // stringbuiler 클래스

        // C#으로 문자열 문제 풀어보신적이 있으면
        // string 값을 저장을 한다음에 
        // + 반복 형식으로 값을 저장해서 결과를 제출하면 메모리 부족 머시기 에러가 뜨면서 실패!

        // append().   ToString()
        void StringBuilderTest()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("AA");
            sb.Append("CC");

            Console.WriteLine(sb.ToString());
        }
    }
}
