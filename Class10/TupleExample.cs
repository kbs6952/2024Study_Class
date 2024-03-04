using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10
{
    public class TupleExample
    {
        // out, ref 출력 전용 매개 변수
        // 메소드는 데이터를 null 또는 지정한 데이터타입 하나만 반환할 수 있습니다.
        // 나누기로 몫, 나머지를 둘다 리턴하고 싶다. 
        // out, ref 

        // out : ref 똑같은 기능을 하지만, 내부적으로 out 매개 변수를 초기화해주지 않으면
        // 컴파일러가 에러를 발생시킨다.

        public void AddExample(int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a + a + b;
        }

        // 데이터를 2개 이상 반환해주는 기능을 C# 제공을 해주었습니다.
        // Tuple
        // 기본 문법: Tuple<T,U>

        // 예시

        public void TestExample()
        {
            List<Tuple<int, string>> list = new List<Tuple<int, string>>();
            list.Add(new Tuple<int,string>(1,"예시1")); 
        }

        // 튜플도 학습을 하고, 일반화 프로그래밍 형식 매개 변수 T를 배웠으니깐
        // 데이터를 3개 데이터 타입을 반환하는 클래스 타입을 새로 선언하지 않아도 쉽게 
        

    }
}
