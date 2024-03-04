namespace Class11
{
    // 11강
    // 학습 목표 : delegate(대리자)와 이벤트를 학습하고 C#의 Winform을 활용하여 계산기를 만들어 본다.
    // 날짜 : 2024-02-23

    // delegate 
    // delegate 사전적 의미는 대리인, 사절 이라는 의미를 가졌습니다.
    // 대리인 또는 대리자란 누군가를 대신해서 일을 해주는 사람을 의미합니다.
    // C#에서 대리자 메소드를 참조해서 대신 불러주는 기능을 합니다.

    // 기본 문법
    // 접근 지정자(public, private, internal private) delegate 데이터 타입 델리게이트 이름(매개 변수);

    delegate int MyDelegate(int a, int b);

    // delegate의 선언 위치
    // namespace 공간에 자유롭게 위치할 수 있고, 클래스 내부에서도 선언할 다.수 있습니
    // delegate는 선언 후 메소드의 주소를 가져오는 객체를 생성하는 설계도라고 볼 수 있습니다.

    // 메소드를 매개변수에 집어 넣어서 그 결과가 나오는 것을 확인할 수 있습니다.

    class DelegateExample
    {
        int Plus(int a, int b)
        {
            return a + b;
        }

        int Minus(int a, int b)
        {
            return a - b;
        }

        public void DelegateTest(MyDelegate callback)
        {
            MyDelegate Callback;
            Callback = callback;

            Console.WriteLine(callback);
        }

       public void Execute()
        {
            MyDelegate CalculateCallback;
            CalculateCallback = new MyDelegate(Plus);
            Console.WriteLine(CalculateCallback(3,4));

            CalculateCallback = new MyDelegate(Minus);
            Console.WriteLine(CalculateCallback(7,5));
        }

    }

    // delegate를 사용하면 메소드를 매개 변수로 사용을 할 수 있는 것을 눈으로 확인하였습니다.
    // 콜백(Call back): 어떤 메소드를 실행 할 때 다른 메소드를 불러와서 실행하는 것을 콜백이라고 합니다.
    


    internal class Program
    {
        static void Main(string[] args)
        {
            //DelegateExample delegateExample = new DelegateExample();
            //delegateExample.Execute();

            //Event_Class event_Class = new Event_Class();
            //event_Class.Main2();

            //for(int i=0; i<30; i ++)
            //{
            //    event_Class.DoSomeThing(i);
            //}

            Bank bank = new Bank(1000);

            Player player = new Player(500, bank.Balance);

            bank.mydelegate += player.DecreasePlayerMoney;

            bank.DecreaseBalance(300);

            // delegate 은닉성을 보완해주기 위하여 제공되는 event의 기능
            // event는 delegate의 기능을 제한해주기 위해서 제공되는 한정자
            // event 선언된 delegate가 다른 클래스에서 직접 선언되어 사용되는 것을 막는 역할을 합니다.
            //bank.mydelegate(100);

            // bank.medelegate.Invoke();

        }
    }
}
