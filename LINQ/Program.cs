using System.Runtime;

namespace LINQ
{
    internal class Program
    {
        // 데이터베이스 다루는 언어. SQL
        // LINQ : 통합 질의 언어 Language Integrated Query
        // 사람이 묻는 것 처럼 언어를 사용하게 만드는 문법 Query문

        // 사용해야 되는 이유: 우리가 실제로 프로그래밍을 작성하면 논리적인 로직을 작성하는 일보다 데이터를 분류하고 관리하는 일을 하는 빈도 수가 더 많습니다.
        // 데이터를 분류하고 정렬한 후 검색하는 코드를 작성하는 것에 시간이 소모되는 경우가 많습니다.

        // 사용법:  from,   where,  orderby,  select,  group

        // 실습 :

       
        static void Main(string[] args)
        {
           
            // database 클래스 내부에서 money 300이상인 객체만 필요하다.
            List<Database> databases = new List<Database>();

            Database[] myDatabase =
            {
                new Database("이순신", 100),
                new Database("기기", 200),
                new Database("니나", 300),
                new Database("라라", 400),
                new Database("사과", 500)
            };

            foreach(Database database in myDatabase)
            {
                if(database.Money >= 300)
                {
                    databases.Add(database);
                }
            }

            databases.Sort(
                (database1, database2) =>
            {
                return database1.Money - database2.Money;
            }
            );

            foreach(var database in databases)
            {
                Console.WriteLine($"{database.Name}이 가지고 있는 돈은 {database.Money}");
            }

            // LINQ 배우면 위의 코드를 아주 간결하게 작성을 할 수 있습니다.

            var databases2 = from database in myDatabase
                             // 1. from절은 쿼리식의 대상이 될 원본 데이터와 각 요소 데이터를 나타내는 범위 변수를 from절에서 지정해줍니다.
                             where database.Money >= 300
                             // 2. where절은 어떤 데이터를 가져와야 할지에 대한 필터 역할을 하는 연산자 입니다.
                             orderby database.Money descending
                             // 3. 데이터의 정렬을 수행하는 연산자 입니다.
                             select database;
            // 4. select절은 최종 결과를 추출하여 database2에 데이터를 넣는 역할을 합니다.



            var databases3 = from database in myDatabase
                                 // 1. from절은 쿼리식의 대상이 될 원본 데이터와 각 요소 데이터를 나타내는 범위 변수를 from절에서 지정해줍니다.
                             where database.Money >= 300
                             // 2. where절은 어떤 데이터를 가져와야 할지에 대한 필터 역할을 하는 연산자 입니다.
                             orderby database.Money descending
                             // 3. 데이터의 정렬을 수행하는 연산자 입니다.
                             select new {Name = database.Name};
            // 4. select절은 최종 결과를 추출하여 database2에 데이터를 넣는 역할을 합니다.

            LINQ_Example test = new LINQ_Example();

            test.Example3();
            test.Example4();

            Console.WriteLine("아래 내용은 예제 5번 입니다");

            test.Example5();

            Console.WriteLine("아래 내용은 예제 6번 입니다");
            test.Example6();
        }
    }

    // LINQ 배우면 위의 코드를 아주 간결하게 작성을 할 수 있습니다.
    // LINQ 사용하기 위한 무명 형식



    class Database
    {
        private string name;
        private int money;

        public string Name => name;
        public int Money => money;

        public Database(string name, int money)
        {
            this.name = name;
            this.money = money;
        }


    }

}
