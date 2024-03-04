using System.Collections; // 라이브러리에 Collections 클래스 등록된 자료 구조를 사용할 수 있다.

namespace Class10
{
    // 10강
    // 학습 목표 : 일반화 프로그래밍 Generic에 대한 학습
    // 날짜 : 2024-02-22

    // 일반화 프로그래밍 : 모든 데이터 타입을 사용하기 위해 고안된 프로그래밍 방법
    // 예시 1. 점수를 획득하는 시스템 있었습니다.
    // 획득한 점수를 더해서 모든 총합 점수를 랭킹으로 변환하는 시스템을 추가하고 싶다.
    // (int) 파괴 점수, 클리어 점수, 이벤트 점수 모두 더해서 시스템을 구현해달라.

    class GenericExample
    {
        
        public void AddScore(params int[] index)
        {
            int total = 0;

            foreach(var item in index)
            {
                total += item;
            }

            Console.WriteLine($"모든 점수의 합은 : {total}입니다.");
        }

        public void AddScore(params float[] values)
        {
            float total = 0;

            foreach(var item in values)
            {
                total += item;
            }

            Console.WriteLine("실수 타입의 점수의 합은 : {total}입니다.");
        }

        public void AddScore<T>(params T[] values) 
        {
            T total;

            Console.WriteLine("점수의 합은 {total} 입니다.");

        } 

        public void CopyData<T>(T source, T target) where T : class // T 값 타입이냐 참조 타입이냐에 따라서 메모리 결과가 달라질겁니다.
        {
            // 값 타입의 복사만 이루어지게 작성을 하고 싶다.
            source = target;
        }

    }


    class Array_int
    {
        private int[] array;

        public int GetElement(int index) { return array[index]; }
    }

    class Array_float
    {
        private float[] array;

        public float GetElement(int index) { return array[index]; }
    }

    class Array_Generic<T> // 모든 데이터 타입 <T> 자리에 넣으면 호환해서 사용할 수 있게 됩니다.
    {
        private T[] array;

        public T GetElement(int index) { return array[index]; }
    }


    // 더하는 기능을 잘 구현해서 랭킹 시스템의 일부분을 개발을 했습니다.
    // 소수점의 점수를 가산해주는 데이터 있는대, 이 데이터도 랭킹 시스템에 반영을 하게 해달라.

    // Data <string, int> ... 랭킹 점수에 반영을...

    // 2가지 일반화 프로그래밍이 존재한다.
    // 1. 메서드 일반화 
    // 2. 클래스 일반화

    // 기본 문법 : 접근지정자 반환타입 메소드이름<T>(T 매개변수 이름){ }

    // 3. 형식 매개 변수 <T> : 모든 데이터 타입을 받아 올 수 있다고 하였습니다.

    // 일반화 프로그래밍에서 구현된 가변 배열 List <T> 

    // 클래스를 만들어서 다양한 데이터를 포함하고 있는 객체를 생성할 수 있습니다.

    class Data
    {
        string name;
        int score;
        int ranking;

    }

    // 모든 데이터를 넣을 수 있는 것은 장점이 될 수도 있지만 불필요한 데이터도 넣을 가능성을 발생시킵니다.
    // 불필요한 데이터를 사용하지 않도록 형식 매개 변수를 제약시키는 방법을 제공합니다.
    // where 절을 통해서 형식 매개 변수를 제한할 수 있습니다.
    // 기본 문법 : class Mylist<T> where T : "키워드"

    // where T : struct    -> T가 값 형식이여야 한다. 조건      
    // where T : class     -> T가 참조 형식이어야 한다.
    // where T : new()     -> T는 반드시 매개 변수가 없는 생성자가 있어야 한다.
    // where T : 기반 클래스 -> T는 명시한 기반 클래스의 파생 클래스어야 합니다.
    // where T : 인터페이스  -> T는 명시한 인터페이스를 반드시 구현하고 있어야 한다.
    // where T : U(또다른 형식 매개 변수) -> T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스어야 한다.

    class GenericTest
    {
        // T 데이터 타입의 인스턴스를 반환하는 일반화 메서드
        // T 타입의 인스턴스는 반드시 매개변수가 없는 생성자를 가지고 있어야 한다.
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }
    }

    class TestClass
    {
        private string name;

        public TestClass(string name)
        {
            this.name = name;
        }
    }

    class Monster
    {

    }

    class MonsterHandler<T> where T : Monster
    {

    }



    internal class Program
    {
        static void Test()
        {
            // 가변 배열을 C#에서 클래스로 만든 ArrayList 예시
            // ArrayList뿐만 아니라 Collections 클래스에 내장된 자료 구조(컬렉션)들은 매개 변수를 object 타입으로 받는다.


            ArrayList arrayList = new ArrayList();

            // ArrayList내부에서 요소를 추가해주는 Add 메소드는 object를 매개변수로 사용하고 있다.

            arrayList.Add(1);
            arrayList.Add("한글");
            arrayList.Add('c');
            arrayList.Add(0.5f);

            // 컬렉션 클래스를 통해서 자료구조를 사용할 수 있게 되었지만
            // 컬렉션 클래스가 매개변수로 object 타입을 사용하기 때문에 성능 상으로 문제가 있을 수 잇다는 것을 파악하였습니다.
            // 이를 해결하기 위한 방법으로 일반화 프로그래밍 C# 지원해주는 Generic에 대해서 학습하도록 하겠습니다.
        }

        static void Main(string[] args)
        {
            GenericExample example = new GenericExample();

            int[] numbers = { 1, 2, 3, 4, 5 };

            example.AddScore<int>(numbers);

            Console.WriteLine("Hello, World!");

            Array_Generic<double> generic = new Array_Generic<double>();
            // generic 데이터 요소를 추가해주는 Add함수를 만들어 준다음에
            generic.GetElement(3);

            // 일반화 자료구조 List 사용 예시
            List<Data> dataList = new List<Data>();

            Data data = new Data();
            Data data2 = new Data();

            int number1 = 1;
            int number2 = 2;

            example.CopyData<Data>(data, data2);

        }
    }
}
