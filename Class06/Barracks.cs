using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class06
{
    // 건물은 SCV 유닛이 건물을 짓습니다.

    // Barracks 건물 클래스를 상속받습니다.

    // 유닛을 생성하는 건물입니다.

    // 배럭스로 생성할 수 있는 유닛 클래스에는 마린, 파이어뱃, 메딕, 고스트

    class SCV : Unit
    {
        public void SelectBuilding(Building building)
        {
            // 생성할 건물이 배럭인가요?

            if(building is Barracks)
            {
                Barracks barrack = (Barracks)building;

                Console.WriteLine($"{barrack}을 짓습니다.");
            }

        }   
    }

    class Building
    {
        // 건물이 가져야 할 공통적인 데이터와 기능을 추가하여 클래스를 관리한다.
    }

    class Barracks : Building
    {

        public void TrainUnit(Unit unit) // 형변환 조건을 사용해서 유닛을 생성시키면 됩니다.
        {
            // "M" 단어를 입력을 받으면 마린을 생성합니다.

            // Input Class를 생성하여 키보드 "키"값을 받는 클래스를 생성한다.
            // string keyValue;
            // Input.GetKey(keyValue){  TrainUnit("Input GetKey로 return 받은 클래스를 넣어준다.") }

           // M키를 입력 하면 Marin을 return

            if(Console.ReadLine() == "M")
            {
                if(unit is Marine) // is 키워드를 사용하면, true 반환하고 false 반환한다.
                {
                    // ? 연산자

                    // Nullable 연산자: null이 될 수 있는 객체로 만들어 주는 연산자
                    // 기본 문법: 데이터 타입? int? 변수 = null;
                    // 해당 데이터가 Null이 가능하게 선언해주는 연산자입니다.

                    Marine? marin = unit as Marine; // as 키워드를 사용하면 형변환이 가능하면 해당 클래스로 형변환을 시켜주고 그것이 아니면 null을 반환한다.
                    Console.WriteLine("실제로 마린을 생성하세요");

                    //marin. // 클래스 인스턴스. 클래스 멤버를 사용할 수 있다. public protected 선언한 멤버를 사용해주는 "."

                    // null인 객체에 대해서 .를 통해 접근을 하면? 

                    // Null 조건부 연산자
                    // 기본 문법: ?.
                    // Null이 아닌것으로 평가되었을 때만 해당 클래스의 멤버에 접근하도록 하는 연산자이다.
                    // if(Marine != null) Marine.Play();
                    // => Marine?.Play(); 이런식으로 줄여서 사용할 수 있다.

                    // Null 병합 연산자 
                    // ??
                    // 기본 문법: 대입할 변수 = 변수(A) ?? 변수(B)
                    // A가 Null이 아니면 A를 넣고 A가 Null이면 B를 넣는다. 

                    Unit unit2 = new Unit();

                    if (unit is null)
                    {
                        unit = marin;
                    }
                    unit ??= marin;
                  

                }
            }
            // "F" 단어를 입력 받으면 파이어뱃을 생성합니다.
            //F키를 입력 하면 Firebay을 return
            else if(Console.ReadLine() == "F")
            {
                if (unit is Firebat)
                {
                    Firebat? firebat = unit as Firebat;
                    Console.WriteLine("실제로 파이어뱃을 생성하세요");
                }
            }
            // "G" 단어를 입력 받으면 고스트를 생성합니다.
            // G키를 입력 하면 Ghost을 return
            else if (Console.ReadLine() == "G")
            {
                if (unit is Ghost)
                {
                    Ghost? ghost = unit as Ghost;
                    Console.WriteLine("실제로 파이어뱃을 생성하세요");
                }
            }
            // "C" 단어를 입력 받으면 메딕을 생성합니다.
            // C키를 입력 하면 medic을 return
            else if (Console.ReadLine() == "C")
            {
                if (unit is Medic)
                {
                    Medic? medic = unit as Medic;
                    Console.WriteLine("실제로 파이어뱃을 생성하세요");
                }
            }
            else
            {
                Console.WriteLine("입력받을 수 없는 키를 입력하였습니다.");
            }
        }
    }

    class Unit
    {
        // 이동, 정지 기능
        // 모든 유닛이 공통적으로 가져야만 하는 기능만 선언한다.
        // 모든 유닛은 이동할 수 있다.
        // 특정 유닛은 Move를 하지만 추가 기능이 있으면 좋겠다. => virtual 키워드를 선언해준다.
        public virtual void Move() { }

        // 모든 유닛은 공격할 수 있는가? => 메딕같이 공격할 수 없는 유닛도 있다.
        // 공통적이지 않은 기능이기 때문에 Unit 클래스에서 선언하면 안된다. => 

        public void Attack() { } // 이렇게 선언하면 유닛이지만 공격할 수 없는 유닛은 구현할 수 없다.
    }

    class Marine : Unit
    {
        // 공격, 스킬, 움직인다, Stop, Hold, Patrol
    }

    class Firebat : Unit
    {
        // 공격, 스킬
    }

    class Medic : Unit
    {
        // 스킬
    }

    class Ghost : Unit
    {
        // 공격, 스킬
    }
}
