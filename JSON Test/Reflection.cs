using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Test
{
    internal class Reflection
    {
        // 리플렉션(Reflection) : 코드에서 객체의 형식(Type)에 저장된 정보를 찾는 메커니즘

        // 1. 리플렉션이 무엇인지 어디에 유용한지
        // (1) 클래스를 생성할 때 메타데이터에 클래스의 정보를 담습니다.
        // 리플렉션은 이 메타데이터 정보를 이용하여 데이터 저장된 모든 정보를
        // 프로그래머가 사용할 수 있게 도와주는 기능을 합니다.

        // ※ 메타데이터(meta) : 데이터안에 들어있는 데이터 정보를 클래스화하여 저장한 데이터입니다.

        public class ObjectToText // static 한정자로 수식이 됬는지 안됬는지 bool
        {
            private string name;
            public string Name
            {
                get => name;
                set => name = value;
            }

            public string Convert(Object obj)
            {
                return null;
            }
        }

        // 2. Type 오브젝트 사용 하는 방법

        // (1) Object 클래스 GetType() 함수(메소드)
        // 기능 : 객체의 형식 정보(Type) 반화하는 기능(메소드)

        void Example()
        {
            int a = 0;

            Type type = a.GetType();
            // Type에 대한 정보를 object의 GetType메소드로 저장을 한다.

            FieldInfo[] fields = type.GetFields();

            foreach(var field in fields)
            {
                Console.WriteLine($"Type: {field.FieldType.Name}, Name: {field.Name}");
            }
        }
        // Reflection 사용 예시를 보여드렸는대..
        // 특정 데이터 형식(Type)에 해당 하는 모든 클래스를 찾을 때 유용합니다.
        // 디버깅이나 에디터 툴을 만들 때 유용합니다.
        // * Attribute를 읽을 때 유용하게 사용됩니다.


        // 3. 리플렉션의 장점과 단점
        // 장점 -
        // 특정 데이터 형식(Type)에 해당 하는 모든 클래스를 찾을 때 유용합니다.
        // 디버깅이나 에디터 툴을 만들 때 유용합니다.
        // * Attribute를 읽을 때 유용하게 사용됩니다.

        // 단점 -
        // 성능 상의 퍼포먼스에 영향을 줍니다.
        // Reflection 사용하지 않고도 기능을 구현할 수 있다면 사용을 하지 않는 것이 권장된다.
        // 
    }
}
