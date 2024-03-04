using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Class_04
{
    // 4강
    // 날짜 : 2024-02-14
    // 학습 목표 : 클래스의 생성 및 기본 개념 학습

    // 클래스
    // 사용자 정의 데이터 자료형이라고 부릅니다.
    // 속성과 함수(메소드)가 포함되어 있으며, 클래스는 객체를 생성해서 접근하고 사용할 수 있는 집합체입니다.

    // 객체 복사
    // 객체 복사하기 : 얕은 복사와 깊은 복사
    // 깊은 복사 : 객체를 메모리 주소를 새로 만들어서 거기에 똑같은 데이터를 복사해서 사용하고 싶다.

    // static 한정자
    // Instance 반대되는 개념이라고 생각하면 쉽습니다.
    // Class 자체만으로도 속성과 기능을 사용해야할 때도 있습니다.
    // 인스턴스화 하지 않고 클래스를 사용하기 위한 방법으로 제공해주는 한정자 static이다.
    // static void Main(){ };
    // 생성되는 Class의 순서가 보장되지 않으면 Programing 순서가 보장되지 않기 때문에
    // static을 선언해서 Prgram 클래스의 인스턴스가 없어도 호출하기 위해서 static으로 호출한다.

    class A
    {
        public A()
        {
            Console.WriteLine("A가 생성되었습니다.");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("B가 생성되었습니다.");
        }
    }

    class Test
    {
        public static int field_3; // 생성된 몬스터 수

        public int field_1;
        public int field_2;

        public Test targetTest; 

        public static void ShowMessage()
        {
            Console.WriteLine("Static 한정자를 사용한 메소드.");
        }

        public void AddField()
        {
            field_3++;
        }

        public void DeepCopy(int a, int b)
        {
            Test targetTest = new Test();
            targetTest.field_1 = this.field_1;
            targetTest.field_2 = this.field_2;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //MyClass2 myclass = new MyClass2();
            //Console.WriteLine("Hello, World!");

            A a = new A();
            B b = new B();

            Test test1 = new Test();
            test1.field_1 = 10;
            test1.field_2 = 20;


            Test test2 = test1; // 원래의 목표는 무엇이었냐면, 얕은 복사가 아닌 깊은 복사를 하고 싶어서 선언을 한겁니다.
            test2.field_2 = 30;

            // 깊은 복사

            Test test3 = new Test();
            test3.field_1 = test1.field_1;
            test3.field_2 = test2.field_2;
  
            Console.WriteLine($"test1의 field1의 값 : {test1.field_1}");
            Console.WriteLine($"test1의 field2의 값 : {test1.field_2}");

            Console.WriteLine($"test2의 field1의 값 : {test2.field_1}");
            Console.WriteLine($"test2의 field2의 값 : {test2.field_2}");

            // static 사용법 
            Test.field_3 = 10;
            test3.AddField();
            test3.AddField();
            Test.ShowMessage();

            Console.WriteLine(Test.field_3); 

            // 어떨 때 static method 쓰면 좋을까?
            // MSDN class안에서 method들이 static 만들어진 것도 있고, 일반 method 생성된 것들이 있어요.
        }
    }
}
