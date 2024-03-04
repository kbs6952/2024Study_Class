using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07
{
    // SOLID 원칙
    // 객체지향 프로그래밍의 특징. //추상화, 은닉화, 다형성, 상속//
    // 객체지향 프로그래밍에서 단골로 나오는 질문 중에 하나입니다.

    // 1. SRP 원칙 : 단일 책임 원칙(Single Responsibility Principle)
    // 클래스를 만드는 거다. 클래스가 단일 책임을 가져야 한다.
    // 다른 클래스와의 커플링을 줄이기 위한 원칙이다.
    // ※ 커플링 : 클래스가 변경 및 수정 될 때 다른 클래스에서 수정 해야하는 경우를 뜻합니다.
    // 커플링이 약할수록 클래스의 확장성이 증가했다고 볼 수 있으며, 이렇게 커플링을 줄이는 작업을 디커플링 작업이라 부릅니다.
    // 코드를 리팩토링 할 때 자주하는 작업 중 하나가 커플링을 디커플링 하는 작업이다.

    class Player // 플레이어에 대한 모든 정보를 갖고 있는 클래스.
    {
        // 스킬 공격을 한다. Skill 공격을 하는 클래스로 분리해서 만들 수 있습니다.
        public SkillManager skillManager;

        // 새로운 기능을 구현하고 싶으면 클래스를 구현을 해서 SRP 원칙에 맞게 클래스를 설계할 수 있다.

        void Initialize()
        {
            skillManager = new SkillManager();
            skillManager.Initailize();
        }

        void UseSkill()
        {
            // 유저가 키를 입력했을 때 그 키에 해당하는 값을 반환하는 Input 클래스 존재합니다.
            // 유니티 게임엔진에서는 Input 클래스를 사용해서 키를 받아 올겁니다.

            // Console.ReadLine() 동적으로 키 조건을 선언..
            if(/*1번 키를 입력했다면*/true)
            {
                skillManager.UseSkill(1);
            }
        }

        // 메서드를 만들어서 기능을 구현할 수 있다.
    }
    // 스킬 쪽에 추가적인 기능을 만들고 싶다. => 수정하려고 보니깐 플레이어 클래스를 수정해야 하네?
    // 클래스는 하나의 책임만 가져야 한다고 했는대. player클래스가 스킬 클래스까지 2가지 책임을 갖고 볼 수 있습니다.

    class SkillManager // 스킬을 수정하고 싶으면 스킬 매니저 클래스와 스킬 클래스를 수정을 하면 됩니다.
    {
        public Skill[] skills;

        public void Initailize()
        {
            skills = new Skill[]
            {
                new Skill("파이어 볼!"),
                new Skill("라이트닝!"),
            };
        }

        public void UseSkill(int skillIndex)
        {
            skills[skillIndex].Activate();
        }
    }

    class Skill
    {
        public string skillName;
        
        public Skill(string name)
        {
            skillName = name;
        }

        public void Activate()
        {
            Console.WriteLine($"{skillName} 사용함!");
        }
    }

    // 2. OCP 개방 폐쇠 원칙 ( Open/Closed Principle)
    // 수정에는 닫혀 있어야하고, 확장성에는 열려 있어야한다는 원칙입니다.
    // 수정에 닫혀 있어야 한다 : 코드의 기능을 추가하려고 할 때 기존 클래스의 내용을 수정 하지 말아야 한다.
    // 장점 : 코드의 안정성이 늘어납니다. 문제가 발생했을 때 확장한 내용에서 코드가 문제 인것을 확정지을 수 있습니다.
    // 코드 간의 커플링이 감소하여 확장성이 높은 코드 설계가 됩니다.

    // 인터페이스를 통해서 예시를 작성을 하였는대요.
    // 인터페이스는 클래스가 가져야할 약속입니다.
    // 인터페이스를 상속하는 클래스들은 공통적인 기능을 반드시 규현해야 한다.
    // 인터페이스의 특징을 이용해서 인터페이스를 상속하는 클래스를 
    // 핸들러 클래스에서 각 클래스를 변수에 대입하여 
    // 하나의 변수에서 하나의 메소드로 다양한 기능을 구현할 수 있다.

    // 3. LSP 리스코프 치환 원칙 (Liskov Subsitution Principle)
    // 모든 하위 클래스는 상위 클래스를 대체할 수 있어야 한다는 원칙입니다.
    // Weapon weapon = new Sword();   검, 나무 몽둥이, 전부다 무기. //  A is B !! 지켜서 코드를 설계해야 한다.
    // Sword , Weapon 둘이 상속하지 않도록 구성할 수 도 있습니다. => Weapon weapon = new Sword(); => 에러가 뜨겠다.
    // 에러가 발생하면 그 때 가서 코드를 직접 찾아가서 원인을 찾거든요!. 다른 사람이 코드를 두번 보지 않게 코드를 설계할 수 있다.
    // 코드를 읽는 가독성을 높여 줄 수 있습니다. A is B !!// 형변환의 is가 아닌.. 집합관계에서의 is입니다.
    // 직사각형과 정사각형의 관계. 
    // 모든 정사각형은 직사각형? -> "A is B"
    
    class Weapon
    {
        public virtual void Attack()
        {
            Console.WriteLine("기본 무기 공격!");
        }
    }

    class IceWeapon : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("얼음 속성으로 무기 공격!");
        }
    }

    class User
    {
        // Weapon 클래스를 상속받는 모든 클래스를 담을 변수
        private Weapon currentWeaon; 

        // 무기를 변경하는 기능
        public void ChangeWeapon(Weapon weapon) // base 클래스 넣어서 -> Weapon클래스를 상속받는 모든 클래스를 오버로딩으로 구현하지 않기 위해서 매개변수로 기본 클래스를 사용한다.
        {
            currentWeaon = weapon;
        }

        public void Attack()
        {
            // ? 연산자 -> 데이터 타입을 null을 가질 수 있게 해주는 연산자
            // ?. 연산자 -> 클래스가 null이 아닐 때만 멤버에 접근을 할 수 있게 하는 연산자
            // 무기를 변경하기 위해서 그 무기를 담을 변수를 선언했지만, 이 변수가 null일 때 문제가 발생함으로 예외처리를 해주어야 한다.
            if (currentWeaon != null)
                currentWeaon.Attack();

            currentWeaon?.Attack();
        }
    }

    class UserManager
    {
        public UserManager()
        {
            User user = new User();
            Weapon baseWeapon = new Weapon();
            IceWeapon iceWeapon = new IceWeapon();

            user.ChangeWeapon(baseWeapon);
            user.Attack();

            user.ChangeWeapon(iceWeapon);
            user.Attack();
        }
    }


    // 4. ISP 인터페이스 분리 원칙 Interface Segregation Principle
    // 분리되어야 된다 -> 사용하지 않는 인터페이스의 기능은 배제해야 한다.  
    // 인터페이스는 약속!
    // 다양한 메소드를 가져야한다고 설계를 할 수는 있습니다.
    // 인터페이스를 사용하는 이유는 각 기능들을 모듈화 해서 필요할 때 마다 부쳤다가 뺏다가 사용할 수 있는 것이 가장 큰 장점입니다.
    // 장점 : 클래스 간의 의존성을 줄여 커플링을 완화할 수 있다.
    // 모듈화된 인터페이스의 수가 많을 수록 다양한 클래스를 쉽게 설계할 수 있다.
    // 저희가 만든 인터페이스, 클래스 ( 자신의 이름의 라이브러리 보관을 할 수 있다.)
    // Utility Class. Helper Class. => 공통적으로 자주 사용되는 기능들을 클래스로 묶어서 선언한 것을 말합니다.
    // 아이템 주석으로 설명을 띄어주는 자막 클래스. => 필요할 때 마다 꺼내서 사용하고, 수정하고 변경해서 업그레이드 시키는 것으로 여러분의 코드를 갖출 수 있게 됩니다.
    // 목표: 게임이나 C# 클래스를 새로 작성할 때 공통적인 기능만 클래스로 분리해서 따로 데이터베이스에 저장을 하시고, 저장한 클래스를 문서로 정리하는 방법을 알려드리도록 하겠습니다.
    // 포트폴리오나 다른 프로젝트 사용할 때 사용해보세요! => 이론적인 4~5일 6일 프로젝트를 만들어보고 클래스 문서화 방식에 대해서 배워보도록 하겠습니다.

    // 인터페이스는 다중 상속이 가능하다.

    interface IMoveAble
    {
        public void Move();
    }

    interface IAttackAble
    {
        public void Attack();
    }

    class Monster : IMoveAble, IAttackAble // 인터페이스를 2개 상속받고 있다. // 모든 몬스터는 이동과 공격을 갖고 있지 않겠구나!
    {
        public void Attack()
        {
            Console.WriteLine("몬스터가 공격합니다.");
        }

        public void Move()
        {
            Console.WriteLine("몬스터가 이동합니다.");
        }
    }

    // 5. DIP 의존 역전 원칙 Dependency inversion Principle
    // 상위 클래스는 하위 클래스에 의존해서는 안되고, 두 클래스는 구현이 아닌 추상화에 의존해야 한다는 원칙입니다.
    // 원칙 : 하위 클래스가 상위 클래스를 의존합니다.
    // 당연한 것 같은대 왜 자꾸 설명하지? - 원칙..


    // SOLID 원칙 정리
    // 객체지향프로그래밍의 5가지 원칙에 대해서 학습을 하였습니다.
    // SOLID 원칙을 지킴으로서 얻을 수 있는 장점 : 확장성과 안정성을 높이는 클래스 설계를 구현할 수 있습니다.
    // 단점 : 5가지 원칙을 전부 지키는 코드를 작성하기 어렵습니다.
    // 만들고 싶은 객체를 이름으로 클래스를 만들어라. 구체성을 바탕으로 코드를 작성해나가는게 일반적인 프로그래머가 작성하는 방식일 것입니다.
    // SOLID 원칙을 준수하면서 프로그래밍 설계를 생산성이 떨어집니다. -> "시간"
    // 궁극적으로 목표로 해야할 것
    // 코어 단계의 프로그래밍 SOLID 원칙을 준수해라
    // ProtoType, Test 단계의 프로그래밍은 생산성을 높여 빨리빨리 코드를 작성하라.

    class SOLID_원칙
    {



    }
}
