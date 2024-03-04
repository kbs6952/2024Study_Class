using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_04
{
    // 1. 클래스의 기본 문법
    // 속성과 함수(메소드)

    // 2. 클래스 생성자
    // 기본 문법
    // 클래스명 호출할 이름(인스턴스) = new 클래스명();
    // MYClass myClass = new MyClass();
    
    // 3. 상속
    //

    class MyClass2
    {
        // 접근 지정자 데이터 타입 이름;
        private int field_01;
        private int field_02;
        public int field_03;
        protected int filed_04;
        int field_05;

        public void CallField(int value)
        {
            field_01 = value;
        }

        public int ReturnField(int value)
        {
            return field_01;
        }

        public MyClass2()
        {

        }

        // 메소드 오버로딩
        public MyClass2(int field_03)
        {
            this.field_03 = field_03;
        }

        #region 접근 지정자
        // 접근 지정자
        // private, public, protected, internal protected, internal public
        // 접근 지정자 뭐냐?
        // 클래스 내부의 포함되어 있는 속성에 접근 범위를 제한하는 지정자입니다.
        // 기능을 사용 못하게 하는 것이 왜 필요해서 쓰이는 걸까?
        // 앱 같은 거 쓸 때.. 사용 방법이 엄청 복잡한 거랑, 버튼 1개만 누르면 되는거랑 있다고 하면 어떤 거 쓰실건가요?
        // 3개월 전에 코드 짠거 다시 본 적 있으신가요?
        // Player 이동하기 위해서 속도가 필요합니다. <- 10 ~ 50 값을 적당한 값을 찾아야하는대. 
        // 1시간 25속도가 답을 찾아냈어요. public. 다른 프로그래머가 ***speed. <- 25 40 


        // protected. 클래스는 다른 클래스를 상속 받을 수 있습니다.
        // base(기반) 클래스에서 속성과 기능을 받아와서 Derived(파생) 클래스가 사용할 수 있게 해주는 것을 상속이라고 합니다.
        // public 쓰면 안될 것 같은대,
        // protected 자신 클래스를 상속하는 파생 클래스에게는 접근응 허용하겠다. 

        // internal 
        // 같은 어셈블리 내에서 public 같은 효과를 갖고, 다른 어셈블리에서는 private 적용되는 접근 지정자.
        // 내가 만든 클래스 내부에 Helper Class 만들 때 쓰는건대.
        // 경고를 띄우는 형태의 기능 구현해주는 클래스

        // 어셈블리 : 컴파일을 통해 만들어진 파일 C# 부르는 말.
        // .exe - : Main메소드가 포함된 클래스는 .exe
        // .dll - : 그 이외의 다른 클래스들이 라이브러리 형태로 저장이된다.

        // Library - Framework
        // 마이크로 소프트가 C#을 .NetFramework에서 구동되는 프로그래밍 언어를 만들었는대,
        // Console.WriteLine(); - Class 들이 어딘가 있겟죠? 라이브러리 - 프로그래머가 원할 때 마다 가져다와서 쓰는 클래스 모음 => 라이브러리
        #endregion
    }

    class Test4
    {
        void CallMyClass()
        {
            MyClass2 myClass = new MyClass2();
            myClass.field_03 = 3;
            Console.WriteLine(myClass.field_03);

            MyClass2 test2 = new MyClass2(3);
        }
    }
}
