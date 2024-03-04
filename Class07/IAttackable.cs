using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07
{
    // 인터페이스의 이름을 정할 때는 첫 글자에 I를 쓰고 이름을 작성하는 규칙을 따른다.
    // 인터페이스의 특징
    // 1. 클래스와 다르게 인스턴스로 생성할 수 없습니다.
    // 인스턴스를 생성해서 클래스는 멤버 안에 있는 기능들을 가져와서 쓴다고 배웠습니다. 객체 지향 프로그래밍 추상화!
    // 2. 인터페이스를 상속하는 클래스가 공통적인 기능을 갖도록 강제하는 역할을 가진 기능입니다.
    // 3. 인터페이스의 목적은 상속을 받는 클래스들이 공통적으로 기능을 사용할 수 있게 하기 위해서
    // internal protected,  public으로 선언을 해줘야합니다. => public.. 
    // internal private.. 사용할 수 없는 에러가 발생한다.

    public interface IAttackable
    {
        // 프로퍼티, 델리게이트, 이벤트

        public void Attack(string message); // IAttackable 인터페이스 내부에 멤버를 접근해서 사용할 수 없기 때문에. 기능을 구현할 필요가 없습니다.
    }

    class Marine : IAttackable
    {
        // delegate, event 나중에 이것에 대해 배운다면
        public void Attack(string message)
        {
            // message(문자) <- 함수, 클래스 메소드 구현을 해서 넣으면 그 기능이 실행이 되겠죠?
            // 매개변수로 메소드를 넣을 수 있습니다.
            Console.WriteLine($"Marine : {message}");
            //throw new NotImplementedException(); // 예외 처리의 일종.. 예외 처리 공부할 때 설명을 드리도록 하겠습니다.
        }
    }

    class Ghost : IAttackable
    {
        public void Attack(string message)
        {
            // 기능을 추가 하면.. => 기능이 확장 되었고

            Console.WriteLine($"Ghost : {message}");
        }
    }

    // 데이터 Entity , Handler//

    public class UnitData
    {
        // 이름, 체력, 공격력, 사거리 .. 
    }

    public class UnitManager
    {
        public UnitData unitData; // 클라이언트 내부의 데이터에서 직접 가져오거나, JSON , ScriptableObject 저장된 데이터를 불러와서 unitData;

        private readonly IAttackable attack; // Iattacble 상속받는 하위 클래스들을 담을 변수
                                             // readonly : 외부에서 수정을 못하게 하기 위해서 선언하는 키워드
                                             // 클래스가 생성되고 나서 내부에서만 수정이 되고 그 이후로는 수정이 불가능하다.
        public UnitManager(IAttackable attack)
        {
            this.attack = attack; // 클래스가 생성될 때 attack에 외부에서 받아온 IAttackable상속받는 클래스를 대입해주고, 이 이후로는 attack변수에 다른 데이터를 대입할 수 없게 된다.
        }

        public void UnitAttackExecute() // 수정에는 닫혀있다.
        {
            attack.Attack("실제로 유닛이 공격하는 기능을 향 후에 만든다."); // Ghost, Marine 각각 자신의 메소드를 실행할 수 있는 것을 보았습니다.
        }

    }

    class Test
    {
        void Example()
        {
           
        }
    }

}
