using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    delegate int Compare<T>(T a, T b); // T 두개의 데이터 타입을 비교 해서 -1 , 0 , 1  (a > b : -1, a = b : 0,  a < b : 1)

    internal class MyClass
    {
        // T 데이터 타입을 저장하는 배열인 DataSet을 compare 비교 대리자를 사용해서 정렬하겠다.
        static void BubbleSort<T>(T[] DataSet, Compare<T> compare)
        {
            int i = 0;
            int j = 0;
            T Temp;

            for(i = 0; i< DataSet.Length- 1; i++)
            {
                for(j=0; j < DataSet.Length - (i+1); j++)
                {
                    // i< j를 비교해서 더 작은 값을 왼쪽으로 이동시킨다.
                    // compare 메소드는 둘이 비교해서 뒤의 값이 더 크면 음수를 -1을 반환한다.
                    if (compare(DataSet[j], DataSet[j+1]) > 0)
                    {
                        Temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = Temp;
                    }
                }
            }

        }

        // 오름차순
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b); // a가 b보다 크면 -1, 같으면 0, 작으면 1을 반환하는 메소드를 불러와서 사용을 할 수 있습니다.
        } 

        // 내림차순
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1; // a가 b보다 크면 1, 같으면 0, 작으면 -1을 반환한다.
        }

        static void Execute()
        {
            int[] array = { 3, 5, 2, 4, 1, 8, 9 };

            // AscendCompare, DescendCompare 오름차순과 내림차순
            BubbleSort<int>(array, new Compare<int>(AscendCompare));
            BubbleSort<int>(array, new Compare<int>(DescendCompare));
        }

        // delegate Chain 문법적인 기능을 갖고 있습니다.
        // 대리자 체인 : 대리자는 여러 개의 메소드를 동시에 참조할 수 있는 기능을 갖고 있습니다.
    }

    delegate void SubScribe(string eventString);

    class SubscribeClass
    {
        void EventOne(string eventString)
        {
            Console.WriteLine($"{eventString}는 첫번째 이벤트 입니다.");
        }

        void EventTwo(string eventString)
        {
            Console.WriteLine($"{eventString}는 두번째 이벤트 입니다.");
        }

        void EventThree(string eventString)
        {
            Console.WriteLine($"{eventString}는 세번째 이벤트 입니다.");
        }

        // 대리자 체인의 기본 문법
        // delegate 변수 += 메소드 이름;

        void Test()
        {
            SubScribe eventSubScription = new SubScribe(EventOne);
            eventSubScription += EventTwo;
            eventSubScription += EventThree;

            eventSubScription("첫번 째 이벤트의 제목 : 버튼을 클릭함");

            // 예시

            eventSubScription -= EventThree; 
            eventSubScription("두번 째 이벤트의 제목 : 게임을 로드 중");
        }
    }
}
