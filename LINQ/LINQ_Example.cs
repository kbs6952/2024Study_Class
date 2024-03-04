using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class LINQ_Example
    {
        // 람다식 식 본문 멤버(Expression-bodied members)
        // 익명 메소드를 만들어서 { } 문 형태를 식으로 표현하기 위해서 사용한다.
        // Func<T>, Action<T> 선언된 대리자를 불러와서 사용할 수 있습니다.
        // 반환 값이 void 매개 변수가 0개인 함수를 식으로 변환해서 람다식으로 표현할 수 있다.
        // C# 6.0 
        // 메소드 .식 본문
        // 식의 결과가 단일 문으로 바로 반환되거나, 단일 문 형태의 메서드로 정의된 정의
        //  () =>  식    delegate를 선언하지 않아도 컴파일러가 형식을 추론해서 자동

        private int coin;
        public int Coin { 
            get 
            {
                return coin;
            }
            set
            {
                coin = value;
            }

        }

        public int Coin2
        {
            get => coin;
            set => coin = value;
        }

        // 클래스는 Object 형식을 상속받고 있습니다.
        // ToString().  Object 타입을 String으로 형변환해주는 메소드를 가지고 잇습니다.

        public override string ToString() => $"{coin}".ToString();
        public void ExampleMethod() => Console.WriteLine(ToString());

        public void ExampleMethod(string empty)
        {
            Console.WriteLine(ToString());
        }
        // 코드 수를 줄이는 방법으로 람다식 사용에 대한 예시입니다.

        public void Example()
        {
            var words = new List<int> { 3, 5, 7, 9 };
            var average = words.Average();
            // IEnumerable 유의해서 살펴봐야 하는대,
            // Linq from   a in dataSet  
            // dataSet(콜렉션) IEnumerable<T> 상속받는 형태여야 한다.
        }

        public void ForeachExample()
        {
            // IEnumerable<T> 타입의 콜렉션은 Foreach문 사용할 수 있다.
            // LINQ 사용함으로서 foreach로 구성된 코드들을 query형태의 코드로 변경할 수 있습니다.

            var datas = new List<string> { "하나", "둘", "셋" };

            foreach(var data in datas)
            {
                Console.WriteLine($"{data} 출력!");
            }

            datas.ForEach(data => Console.WriteLine($"{data} 출력!"));
        }

        // LINQ 효과를 보기 위해서는 대량의 데이터와 검색, 정렬, 그룹화 등의 여러 연산이 복합적으로 이루어질 때 
        // LINQ가 유용하게 사용됩니다.

        public void Example3()
        {
            AttackInfo[] attackInfos =
            {
                new AttackInfo(){Name="이단 베기",   AttackValues = new int[]{20,25}},
                new AttackInfo(){Name="좌우 베기",   AttackValues = new int[]{30,35}},
                new AttackInfo(){Name="상하단 베기", AttackValues = new int[]{40,55}}
            };

            // attackinfo에서  value의 값이 30 이상인 데이터 중에서
            // 새로운 객체의 정보를 저장하는대, 이 객체에는 AttackInfo의 Name과 AttackInfo 단일 데이터 value를 저장하는
            // 객체를 LINQ 선언을 해보세요.

            var infos = from info in attackInfos             // IEnumerable<T>
                          from value in info.AttackValues                  // 
                          where value > 30   
                          select new { info.Name, AttackInfo = value };

            foreach( var info in infos)
            {
                Console.WriteLine($"공격 스킬 이름:{info.Name}, 공격력이 얼마인가요?{info.AttackInfo}");
            }

            // 여러 개의 데이터 원본에 질문하는 방법
            // 클래스 형식의 데이터 내부에 collections를 데이터로 또 가지고 있다면
            // 클래스 내부의 콜렉션의 특정 데이터만 추출하는 또다른 자료구조를 
            // LINQ로 받아올 수 있다.
        }

        // 2개의 데이터를 그룹해서 분류하기
        // groupBy
        // 기본 문법 group A by B into C
        // LINQ를 사용해서 기존 데이터베이스를 사용하고 싶은 새로운 데이터베이스로 묶어서 분류하기 위한 방법
        public void Example4()
        {
            AttackInfo[] attackInfos =
            {
                new AttackInfo(){Name="이단 베기",   AttackValues = new int[]{20,25}},
                new AttackInfo(){Name="좌우 베기",   AttackValues = new int[]{30,35}},
                new AttackInfo(){Name="삼단 베기", AttackValues = new int[]{40,55,75}}
            };

            MonsterInfo[] monstserInfos =
            {
                new MonsterInfo(){Monstername = "초급 모험가",  AttackName="이단 베기"},
                new MonsterInfo(){Monstername = "중급 모험가",  AttackName="좌우 베기"},
                new MonsterInfo(){Monstername = "고급 모험가",  AttackName="중단 베기"},
            };

            // 기본 문법 group A by B into C

            var Infos = from attackInfo in attackInfos
                        group attackInfo by attackInfo.AttackValues.Count() >= 3 into g
                        select new { GroupKey = g.Key, Group = g };

            foreach(var info in Infos)
            {
                Console.WriteLine($"공격이 3개 이상? : {info.GroupKey}"); // true / false 반환

                foreach(var item in info.Group)
                {
                    Console.WriteLine($"{item.Name}, {item.AttackValues.Count()}");
                }
                        
                      
            }
        }

        // 두 데이터를 연결하는 기능 Join
        // 내부 조인 - 외부 조인
        // 1. 내부조인 : 두 데이터의 원본 사이에서 일치하는 데이터들만 연결하여 반환합니다.
        // 일치하는 데이터 중에서 첫 번째(왼쪽) 데이터를 기준으로 두번 째(오른쪽) 데이터를 비교해서 일치하는 데이터만 모아 반환합니다.
        // 일치하지 않는 데이터는 버려집니다.
        
        // 2. 외부조인 : 왼쪽 조인, 오른쪽 조인, 완전 외부 조인

        public void Example5()
        {
            AttackInfo[] attackInfos =
            {
                new AttackInfo(){Name="이단 베기",   AttackValues = new int[]{20,25}},
                new AttackInfo(){Name="좌우 베기",   AttackValues = new int[]{30,35}},
                new AttackInfo(){Name="삼단 베기", AttackValues = new int[]{40,55,75}}
            };

            MonsterInfo[] monstserInfos =
            {
                new MonsterInfo(){Monstername = "초급 모험가",  AttackName="이단 베기"},
                new MonsterInfo(){Monstername = "중급 모험가",  AttackName="좌우 베기"},
                new MonsterInfo(){Monstername = "고급 모험가",  AttackName="중단 베기"},
            };

            var monsterList =
                from attackInfo in attackInfos
                join monsterinfo in monstserInfos on attackInfo.Name equals monsterinfo.AttackName
                select new
                {
                    Name = attackInfo.Name,
                    AttackValues = attackInfo.AttackValues,
                    Monstername = monsterinfo.Monstername
                };

            foreach(var monster in monsterList)
            {
                Console.WriteLine($"몬스터의 이름{monster.Monstername}, " +
                    $"몬스터의 공격 스킬 이름{monster.Name}, " +
                    $"몬스터의 공격 횟수:{monster.AttackValues.Count()}");
            }
        }

        public void Example6()
        {
            AttackInfo[] attackInfos =
           {
                new AttackInfo(){Name="이단 베기",   AttackValues = new int[]{20,25}},
                new AttackInfo(){Name="좌우 베기",   AttackValues = new int[]{30,35}},
                new AttackInfo(){Name="삼단 베기", AttackValues = new int[]{40,55,75}}
            };

            MonsterInfo[] monstserInfos =
            {
                new MonsterInfo(){Monstername = "초급 모험가",  AttackName="이단 베기"},
                new MonsterInfo(){Monstername = "중급 모험가",  AttackName="좌우 베기"},
                new MonsterInfo(){Monstername = "고급 모험가",  AttackName="중단 베기"},
            };

            var monsterList =
                from attackInfo in attackInfos
                join monsterInfo in monstserInfos on attackInfo.Name equals monsterInfo.AttackName into g
                from monsterInfo in g.DefaultIfEmpty(new MonsterInfo()
                {
                    Monstername = "존재하지 않는 데이터" // => 기본 데이터를 넣어줍니다.
                })
                select new
                {
                    Name = attackInfo.Name,
                    AttackValues = attackInfo.AttackValues,
                    Monstername = monsterInfo.Monstername
                };

            foreach(var monster in monsterList)
            {
                Console.WriteLine($"몬스터의 이름{monster.Monstername}, " +
                 $"몬스터의 공격 스킬 이름{monster.Name}, " +
                 $"몬스터의 공격 횟수:{monster.AttackValues.Count()}");
            }
               
                    

        }

    }



    class AttackInfo
    {
        private string name;
        public string Name
        {
            get => name;
            set => name = value;
        } 
        private int[] attackValues;
        public int[] AttackValues
        {
            get => attackValues;
            set => attackValues = value;
        } 
    }

    class MonsterInfo
    {
        public string AttackName;
        public string Monstername;
    }
}
