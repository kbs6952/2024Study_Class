using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05
{
    // 메소드에 기본 개념과 C#에서 제공해주는 기능

    class MethodClass
    {
        private string name;

        // 1. 함수의 반환 형태 : 아무 것도 반환하지 않을 때는 void선언하고, 특정 데이터 타입을 반환하고 싶다면
        // 해당 데이터 타입을 선언 해주면 된다.
        // 메소드 코드 내부에서 return을 사용하여 메소드가 해당 데이터를 반환해준다.

        public /*반환 형태 */ void MethodTest()
        {

        }
        public String GetName()
        {
            return name;
        }

        // 메소드 오버로딩 : 컴파일러가 함수의 이름과 매개 변수까지 포함하여 함수를 구분하기 때문에
        // 같은 이름의 함수를 사용할 수 있게 지원해준다.

        public void MethodTest(int a)
        {
            // 
        }

        public void Add(int a, int b)
        {
            int temp = a + b;
            Console.WriteLine(temp);
        }

        public void Add(float a, float b)
        {

        }

        public void Add(int a, int b, int c)
        {

        }

        // params 가변 길이 매개 변수
        // 기본 문법 매개 변수(params 데이터타입[] 이름)
        // 2,3,4,5.... "같은" 데이터 타입의 오버로딩을 할 필요 없이
        // params 키워드를 사용하면 "같은" 데이터 타입이면 모든지 호환하여 사용이 가능하다.
        public void Add(params int[] arr)
        {
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void ObjectCall(params object[] args)
        {

        }

        // 참조 타입의 깊은 복사, 얕은 복사와 메소드에서의 값 복사와, 참조 복사를 이해하기 위해
        // 메소드에서 참조에 의한 매개변수(ref)와 출력전용 매개 변수(out)

        // 참조에 의한 매개변수의 필요성?
        // 나누기

        public int Divide(int num, int divider, out int remain) // num 숫자를 divider로 나누어서 나눈 몫을 리턴하겠다.
        {
            num++;
            divider++;

            int value = num / divider;
            remain = num - value;
            return value;
        }
        // out 출력전용 매개변수
        // ref와의 차이점이 무엇이냐 하면
        // ref는 반드시 함수 밖에서 매개변수에 할당할 데이터를 미리 선언을 해주어야 합니다.

        // ref는 선언 해놓고 메소드 안에서 데이터를 사용을 안해도 컴파일이 에러를 발생을 하지 않습니다.
        // out을 제공 해준겁니다. out은 내부적으로 데이터를 사용하지 않으면 컴파일이 자동으로 에러를 발생 시켜줍니다.
    }
}
