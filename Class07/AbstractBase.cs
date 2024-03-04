using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07
{
    // abstract 클래스 : 추상화 클래스에 대한 학습
    // 추상 클래스는 일반 클래스와 인터페이스의 중간에 있는 개념이라고 볼 수 있다.
    // 추상 클래스의 특징
    // 1. 인스턴스를 만들 수 없습니다 -> 인터페이스
    // 2. virtual 키워드 override 기능을 구현을 할 수 있었습니다.
    // virtual 대신에 abstract override 기능을 제공해주고 있습니다.
    // 3. 코드 구현부를 작성을 안한다 - abstract 클래스는 작성을 할 수 있습니다.
    // 4. abstract 메소드는 반드시 구현을 해줘야 합니다.
    // 일반 클래스가 갖고 있는 기능 - 
    // 인터 페이스가 갖고 있는 기능 -

    abstract class AbstractBase // 인스턴스를 만들 수 없다. => 상속해서 사용해야 한다. abstract 선언한 클래스는 반드시 파생 클래스에서 구현해야한다.
    {
        public abstract void SomeMethod();
    }

    // interface말고 abstract 클래스를 사용해야 하는 이유가 무엇인가?
    // "class" 만드는 기능을 제공을 해주는대, 
    // "A is B" 형변환의 is 말고.. 상속을 구현할 때 A와 B 집합관계를 생각해서 상속을 해야한다.
    // 기반이 되는 클래스를 인스턴스화 해서 사용할 수 없지만, 이 클래스를 상속하고 나서 사용을 하되,
    // 인터페이스의 반드시 메소드를 구현해야 하는 기능을 추가적으로 제공해서 사용하는 클래스 사용법.

    class Derived : AbstractBase
    {
        public override void SomeMethod()
        {
            // 파생 클래스의 기능을 구현한다.
            Console.WriteLine("Derived 클래스의 SomeMethod 호출");
        }
    }
}
