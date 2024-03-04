using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class 학습_목표
    {
        // 3강
        // 날짜 : 2024-02-13
        // 학습 목표 :
        // (1) 조건문, 반복문, 점프문 학습
        // (2) 문자열 처리에 대한 학습

        // 조건문 if . switch

        // if( 논리연산자를 써서 데이터 크다 , 작다, 같거나 다르다 ) => True, False
        // True이면 { } 코드블럭 내용을 실행하라.

        public void Test()
        {
            int a = 10;
            if( a < 10)
            {
                Console.WriteLine("a는 10이 맞습니다");
            }
            else if ( a > 10)
            {
                Console.WriteLine("a는 10이 아닙니다");
            }
            else
            {
                Console.WriteLine("");
            }
        }

        // switch : c# 상수, 문자열  조건으로 받습니다. 조건과 case 머시기 같으면 실행하라.

        public void SwtichTest()
        {
            int key;
            key = int.Parse(Console.ReadLine());

            switch (key)
            {
                case 1:                
                    // 내용을 실행한다.
                    break;
                case 2:
                    break;
                default:
                    break;
            }

        }

        // 반복문 for, while, foreach문

        // for( 초기화  ; 조건부  ;  연산 )

        // 코드조각 구문의 첫 이름을 입력하고 나서 tab을 두번 입력하면 IDE에 등록된 자동 구문이 복사되어 코드에 나타난다.

        void LoopTest()
        {
            for (int i = 0; i < 10; i++)
            {

            }

            while (/*조건 */true)
            {
                int a = 10;
                /*while 반복문이 끝나는 조건 */
                if (a == 10)
                break;
            }

            // while 문을 쉽게 작성하는 Tip
            while (true)
            {
                // 코드 기능을 구현을 하시고

                // 이 반복문이 끝나는 조건을 if문으로 작성한다.
                int a = 10;
                if (a == 10)
                    break;
            }
            // true에 해당하는 조건을 넣어서 향 후에 문제가 없게 설게하는 것이 좋다.

            // do while

            do
            {
                // 코드블럭이 한번은 실행된다.
            }
            while (true);

            // foreach문  배열, 컬렉션, 일반화 프로그래밍
            // IEnumerable 인터페이스를 상속받은 객체에 대해서만 사용할 수 있는 구문
            // 기본 문법

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            foreach(var item in arr)
            {
                int temp;
                temp = item;
                // item 
            }

            for (int i = 0; i < arr.Length; i++)
            {
                // arr[i] = .....
            }

        }
    }
}
