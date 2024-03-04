using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    // 게임 -> "이벤트" : 어떤 사건이 발생하는 것
    // 문법적으로 event

    // event : delegate를 수식하는 한정자입니다. const 
    // event를 사용한다 : 특정 사건이 발생 했을 때 이를 알려 준다.
    // 게임에서 이벤트가 발생했다. "!"(몬스터를 마주쳤다) -> (게임 로직 실행)
    // 프로그래밍에서 event. 컴파일러가 어떤 delegate(event) 사용되었을 때( 데이터가 변경 되거나 새로운 소식을 알려줄 때) 호출한다.


    // event를 사용 방법
    // 1. 대리자를 선언합니다.
    delegate void EventHandler(string message);

    // 2. 클래스를 생성하고 클래스 내부에 1번에서 선언한 대리자의 인스턴스를 event로 수식해서 선언합니다.

    // 3. 이벤트 핸들러를 작성합니다. 1번에서 선언한 대리자 형식을 따르는 메소드를 선언합니다.

    // 4. 클래스의 인스턴스를 생성하고 이 객체의 이벤트에 3에서 작성한 이벤트 핸들러를 등록합니다.

    internal class Event_Class
    {
        // 2번
        public event EventHandler eventHandler; 

        // 3번
        public void EventOccur(string message)
        {
            Console.WriteLine(message);
        }

        public void Main2()
        {
            //4번
            Event_Class eventClass = new Event_Class();
            eventClass.eventHandler += new EventHandler(EventOccur);
        }

        public void DoSomeThing(int number)
        {
            int temp = number % 10;

            if(temp != 0 && temp % 3 == 0)
            {
                EventOccur($"{number}는 3의 배수입니다");
            }
        }
    }
}
