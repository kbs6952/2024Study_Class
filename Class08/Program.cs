namespace Class08
{
    using System.Collections;

    internal class Program
    {
        // IEnumerator , IEnumerable 두개의 인터페이스

        // 반복문.. "foreach문"

        static int[] numbers = { 1, 2, 3, 4, 5, 6 };

        static List<int> list;

        static void Test()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"For문으로 출력한 숫자는 {numbers[i]}입니다");
            }


            foreach(var number in numbers)
            {
                Console.WriteLine($"Foreach로 출력한 숫자는 {number}입니다");
            }
        }

        // For문과 Foreach 문의 차이점
        // 조건문, 증감식, 세미클론 2개를 더 사용합니다.
        // 눈으로 봤을 때 for문에서의 조건을 파악하기 보다는 foreach문을 사용했을 때 코드 파악하기가 용이합니다.
        // Foreach문을 사용하기 위해서는 조건이 필요합니다. {numbers}안에는 배열 또는 컬렉션이 들어가야하는대.. 
        // Array, Collections 클래스를 사용해야 하는대, IEnumerator , IEnumerable 상속받고 있어야 합니다.


        // foreach문을 사용하기 위한 조건으로는 객체가 IEnumerable, IEnumerator 클래스를 상속하고 있어야 한다.

        // 1. IEnumerator 인터페이스
        // GetEnumerator(); : IEnumerator 형식의 개체를 반환한다.
        // yield return문의 도움을 받아서 IEnumerator를 반환합니다.
        // ※ yield 키워드
        // 호출자에게 컬렉션 내부의 데이터를 하나씩 리턴할 때 사용하는 키워드입니다.
        // c++ iterator 비교해서 공부해보시면 되고,
        // yield return : 컬렉션 데이터를 하나 리턴한다. 
        // yield break  : 반복문을 중지하고 루프를 빠져나온다.

        // boolean MoveNext()    : 다음 요소로 이동하고, 컬렉션이 끝난 경우 false를 반환, 성공한 경우 true를 반환.
        // void Reset()          : 컬렉션의 첫 번째 위치의 "앞"으로 이동합니다. "-1"번으로 인덱스를 이동시킨다.
        // Object Current {get;} : 현재 컬렉션의 요소를 반환합니다.


        // 2. Enumerable 타입
        // IEnumable 인터페이스를 상속받고 내부적으로 IEnumerator 인터페이스를 상속받고 있는 클래스가 구현되어 있는 자료형.
        // 공통된 데이터 타입을 반복문으로 실행하여 Enumerator를 반환하고 내부적으로 MoveNext Boolean 타입이 false가 될 때까지 반복하는 작업을 한다.

        class MyEnumerator : IEnumerable, IEnumerator
        {
            private int[] array; // 배열을 선언. 0번 ~ Length
            int position = -1; // 컬렉션안에 데이터를 모두 순회하기 위한 조건인 MoveNext를 실행을 했을 때 0번이 되기 위해서 -1로 설정해줌! 

            public Object Current => array[position];

            public MyEnumerator()
            {
                // 배열의 크기를 3으로 초기화
                array = new int[3];
            }

            // 인덱서. array[0]
            // 기본 문법 : 데이터 반환 this[int index]
            // 컬렉션 또는 배열의 이름[index] 데이터를 접근할 수 있다.

            // int temp = array[0] 값을 줘! 
            // array[0] = value;

            public int this[int index]
            {
                get { return array[index]; }
                set
                {
                    // 예외 처리
                    if(index >= array.Length)
                    {
                        // 에러가 발생햇습니다. return.. 

                        // 크기를 늘려야 하는 상황이 왔을 때 자신의 메모리 크기를 변경하는 로직을 사용합니다.
                        Array.Resize<int>(ref array, index + 1); // 배열의 크기를 다시 할당해주는 메소드입니다.
                        Console.WriteLine($"배열이 재할당 되었음 : {array.Length}");
                    }
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                yield return numbers[0];
                yield return numbers[1];
                yield return numbers[2];
                yield break;

                yield return numbers[3];
            }

            public bool MoveNext()
            {
                // 모든 자료구조 안의 인덱스를 순회해서 true와 false 반환하는 기능

                if(position == array.Length - 1) // 
                {
                    Reset();
                    return false;
                }

                position++;
                return (position < array.Length);
            }

            public void Reset()
            {
                position = -1; // -1 로 설정하는 이유는. GetEnumerator를 순회할 때 MoveNext로 실행하고 나서 0을 반환하기 위해서.
            }
        }

        static void Main(string[] args)
        {
            Test();

            Console.WriteLine("Hello, World!");

            int[] myints = { 1, 2, 3 };

            MyEnumerator enumerator = new MyEnumerator();

        }
    }
}
