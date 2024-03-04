using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05
{
    // 컴퓨터랑 플레이어는 랜덤으로 값을 지정을 받습니다.
    // 플레이어에게는 컴퓨터와 자신의 값을 바꿀 기회를 제공하고
    // 단, 컴퓨터의 값은 숨겨져 있습니다.
    // 운으로 플레이어가 바꿀지 말지 결정을 하여 승부가 나는 간단한 미니 게임.

    class Swap
    {
        // 랜덤.
        // C# 라이브러리 클래스 많이 제공해준다.

        Random random = new Random();
        private int playerValue;
        private int computerValue;

        // 은닉화를 지키면서 playervalue, computerValue에 접근할 수 있는 코드를 작성해보세요.

        // 실습1.프로퍼티를 사용해보세요

        public int PlayerValue => playerValue;
        public int ComputerValue => computerValue;


        public void GameStart()
        {
            //Loading()
            RollDice();
            SelectValue();
            ShowResult();
        }

        public void RollDice()
        {
            // 1 ~ 6의 값을 랜덤으로 받아 올 수 있다.
            playerValue = random.Next(1, 7); 
            computerValue = random.Next(1, 7);
        }

        public void SwapValue()
        {
            // player의 값과 computer의 값을 변경하는 코드를 작성해보세요
            int temp = playerValue;
            playerValue = computerValue;
            computerValue = temp;
        }

        // SwapValue 기능을 유저가 사용할 지 말지 선택하는 기능을 한번 만들어 보세요

        public void SelectValue()
        {
            // Yes 키워드를 저장하고 있는 버튼을 입력 Y() Swap해라 조건문
            if (Console.ReadLine() == "Y")
            {
                SwapValue();
            }
            // Choice에 해당 하는 string 입력 시 변경한다.(Yes)
            // No 입력 시 변경하지 않고 진행한다.
        }


        public void ShowResult()
        {
            Console.WriteLine("변경 결과를 기다리는 중입니다.");
            Thread.Sleep(500);

            Console.WriteLine($"Player의 값은 :{playerValue} 이다.");
            Console.WriteLine($"Computer의 값은 : {computerValue} 이다.");

            if(playerValue > computerValue)
            {
                Console.WriteLine("승리");
            }
            else if(playerValue < computerValue)
            {
                Console.WriteLine("패배");
            }
            else
            {
                Console.WriteLine("무승부");
            }

            Console.WriteLine("게임이 종료되었습니다.");
        }
    }
}
