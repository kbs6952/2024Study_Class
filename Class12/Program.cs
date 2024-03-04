using System.Data.SqlTypes;
using System.Threading.Channels; 

namespace Class12
{
    // 학습 목표 : 람다식에 대한 이해와 사용
    // 날짜 : 2024-02-27

    // 람다식은 수학에서 람다 계산법으로 부터 유래되었습니다.
    // 람다 계산법 : 간결한 방법으로 함수를 묘사하기 위한 계산 방법. 
    // 프로그래밍에서 람다 계산법을 적용할 수 있게 구현을 했습니다.
    // 파이썬, C#, 자바.. 람다식을 지원을 해줬어요.

    // 람다식의 목적은 익명 메소드를 만들기 위해 사용합니다.
    // 익명 메소드가 무엇인가?
    // Delegate 선언한 변수 안에 - 지금 막 만든 메소드를 작성해서 데이터를 넣은 다음에

    // 람다식의 기본 문법
    // 매개 변수 => 식
    // "=>" 입력 연산자 : 왼쪽 매개 변수를 오른 쪽 식에 전달하는 연산자입니다. 

    // "식", "문"
    // 식(expression) : 한 줄로 표현한 코드.
    // 문(statement)  : 여러 줄로 표현한 코드. -> { 중괄호를 사용해서 코드를 작성한다.}

    delegate int Caculate(int a, int b); 
    delegate void Test();

    class Program
    {
        Caculate cal1 = delegate (int a, int b)
        {
            return a + b;
        };

        Caculate cal2 = (int a, int b) => a + b;

        // 형식 유추
        // 사용해야 할지 말아야 할지
        Caculate cal3 = (a, b) => a + b;

        // 문형식의 람다식
        Test test = () =>
        {
            Console.WriteLine("문형식의 람다식");
            Console.WriteLine("을 사용하는 예시");
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    
    // delegate에서 익명 메소드에 대한 문법을 지원해줄 때 C#2.0 람다식을 지원을 해주지 않았습니다.
    // 람다식을 지원해주기 시작하였는대, 
    // 기존의 기능을 완벽히 대체하는 새로운 기능을 구현을 했는대. 그럼에도 불구하고 기존의 기능을 살려두는 이유가 무엇일까?
    // 새로운 기능으로 대체가 가능하더라도 기존에 만들어진 코드에 호환이 되지 않으면 이전 프로그램을 사용할 수 없기 때문에 
    // 새로운 기능이 추가되더라도 일정 기간 기능을 유지해 둡니다.


    // 람다식을 사용을 하면 함수를 표현할 때 식으로 간결하게 표현할 수 있다.
    // 단점 : 익명 메소드의 사용법이기 때문에 delegate를 선언을 해야 사용할 수 있다.
    // 사전준비가 필요하기 때문에 이 문법을 사용을 할 때 실수를 할 가능성이 생깁니다.

    // C#에서 제공해주는 기본 대리자
    // 1. Func 대리자   : 매개 변수를 17개 가지는 오버로딩으로 반환 값이 있는 대리자 형식 입니다.
    // Func의 형식 매개 변수 가장 뒤에 나오는 데이터 형식을 반환 값의 형식으로 한다.

    class Lamda
    {

        void FuncTest()
        {
            Func<int> func1 = () => 10;
            Func<int, int> func2 = (a) => 20;
            Func<int, int, int> func3 = (a, b) => a + b;
        }

        void ActionTest()
        {
            Action act1 = () => Console.WriteLine("반환 값이 없는 Action 대리자");
            Action<string> act2 = (message) => Console.WriteLine($"{message}를 매개변수로 해당 메시지 출력하는 Action 대리자");

            act1();
            act2("보내고 싶은 메시지");
        }
    }


    // 2. Action 대리자 : 반환 값이 없는 대리자 형식 입니다.

    // 람다식의 활용

    // 

    class SampleClass
    {
        // 1. 프로퍼티
        private int coin;
        public int Coin
        {
            get { return coin; }
            set { coin = value; }

        }

        public int ReturnCoinValue()
        {
            return coin;
        }


        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        }

        // 2. 인덱서

        private List<string> list = new List<string>(0);
        public string this[int index] => list[index];

        // 3. 메소드
        public void ListAdd2(string addString)
        {
            list.Add(addString);
        }

        public void ListAdd(string addString) => list.Add(name);

        // 4. 생성자

        public SampleClass(int coin)
        {
            this.coin = coin;
        }

        public SampleClass(string name) => this.name = name;

    }


}
