namespace Class07
{
    internal class Program
    {
        // 7강
        // 학습 목표 : 추상화에 대한 학습 interface와 abstract virtual 3가지의 사용법과 차이점 배워보도록 하겠습니다.
        // 날짜 : 2024-02-19




        static void Main(string[] args)
        {
            IAttackable attack = new Marine();
            IAttackable attack2 = new Ghost();

            UnitManager unitManager = new UnitManager(attack);
            unitManager.UnitAttackExecute();

            UnitManager ghostManager = new UnitManager(attack2);
            ghostManager.UnitAttackExecute();

            Console.WriteLine("2024.02.20 예시");

            UserManager userManager = new UserManager();

        }
    }
}
