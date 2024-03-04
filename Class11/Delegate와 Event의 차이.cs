using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class11
{
    public delegate void Mydelegate(double money);

    class Delegate와_Event의_차이
    {
       

    }

    class Bank
    {
        double balance;

        public Bank(double initMoney)
        {
            this.balance = initMoney;
        }

        public double Balance => balance;

        public event Mydelegate mydelegate;

        public void DecreaseBalance(double money)
        {
            balance -= money;
            // 콜백 기능
            mydelegate.Invoke(money);

        }
    }

    class Player
    {
        double totalMoney;
        double currentMoney;

        public Player(double currentMoney, double bankMoney)
        {
            totalMoney = currentMoney + bankMoney;
        }

        public void DecreasePlayerMoney(double money)
        {
            totalMoney -= money;
        }
    }



}
