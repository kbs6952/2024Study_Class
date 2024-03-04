using System.Threading.Channels;

namespace Class06
{
    internal class Program
    {
        // 클래스의 상속과 다형성
        // 객체지향 프로그래밍의 원칙. SOLID 원칙.

        // 추상화, 은닉화, 캡슐화, 상속성, 다형성

        // 메소드 오버라이딩, 메소드 매개 길이 변수 params

        // 속성과 기능.

        // 클래스 :
        // 데이터를 저장하는 용도로 클래스를 선언 Entity
        // 저장한 클래스를 이용하여 기능을 만드는 Handler

        class Player
        {
            // 무기를 가지고 공격을 하는 기능을 만들려고 합니다.
            // 어떤 무기 인가? (무기에 대한 데이터)
            
            // Attack 함수 안에 무기 이름을 직접 지정을 하였더니, 다른 무기는 어떻게 할 건대?
            public void Attack(WoodBat woodBat)
            {
                // 어떤 무기를 클래스로 받아와서 함수를 실행하면은 Attack함수를 하나만 써서 공격을 할 수 있게 되었다.
                Console.WriteLine($"{woodBat} 플레이어가 공격을 했다.");
            }

            public void Attack(Sword sword)
            {
                // 
            }

            // 데이터로 사용할 클래스의 갯수 만큼 메소드를 만들어야 하는 상황에 직면하였다.
            // 이를 해결 하기위한 방법이 무엇이 일까? 클래스의 상속

            public void Attack(Weapon weapon)
            {
                // Weapon을 상속 받은 모든 파생 클래스를 가져와서 사용할 수 있습니다.
            }


            public void EquipProps(Armor armor)
            {
                armor.Equip();

                SpikeArmor armor2 = (SpikeArmor)armor;
                armor2.Equip();

            }

        }

        class Weapon
        {

        }

        class WoodBat : Weapon
        {
            // 속성.....
        }

        class Sword : Weapon
        {

        }

        // 클래스의 메소드의 확장? virtual, override, new



        class Armor
        {
            // 다형성 : 같은 이름으로 다른 기능을 구현하는 것
            public virtual void Equip() // 이 virtual 키워드를 선언한 함수는 내 자식이 override해서 사용해라
            {
                Console.WriteLine("갑옷을 장착하였습니다.");
            }

            public void Equip2()
            {

            }

        }

        // 상속을 하면 부모의 데이터를 가져와서 사용할 수 있다.
        // 상속을 클래스의 확장을 도와주는 기능을 갖고 있다.
        class SpikeArmor : Armor
        {
            public override void Equip()
            {
                Console.WriteLine("갑옷을 장착하였습니다.");
                Console.WriteLine("가시가 추가로 장착하였습니다.");
            }

            public new void Equip2() // new 부모랑 같은 이름의 함수를 선언하였을 때 부모의 함수를 숨기는 기능을 한다.
            {
                // new 키워드는 부모의 메서드를 숨겼기 때문에 메모리 상에 부모의 함수가 남아있으며,
                // 이 남아있는 메서드를 불러와서 쓸 수 있다.
                Console.WriteLine("갑옷을 장착하였습니다.");
                Console.WriteLine("가시가 추가로 장착하였습니다.");
            }

        }

        // 부모와 자식간에는 형변환이 가능합니다.
        // 부모 -> 자식 클래스 형 변환(다운 캐스팅)
        // 자식 -> 부모 클래스 형 변환(업 캐스팅)


        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("밥을 먹습니다.");
            }
        }

        class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("멍멍 짓습니다.");
            }
        }

        class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("야옹 하고 웁니다.");
            }
        }


        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            Animal[] animals = { animal, dog, cat };

            foreach(var item in animals)
            {
                item.Eat();

                // is 사용법
                if(item is Dog)
                {
                    Dog dog2 = (Dog)item;

                    dog2.Bark();                  
                }

                // as 사용법
                var dog3 = item as Dog;
                if (dog3 != null) dog3.Bark();

                var cat3 = item as Cat;
                if(cat3 != null) cat3.Meow();
              
              
            }


            Console.WriteLine("Hello, World!");
        }
    }
}
