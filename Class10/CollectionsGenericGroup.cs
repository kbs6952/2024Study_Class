using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class10
{
    // Collections ArrayList, Stack, Queue, Hashtable 클래스로 선언하여 사용해보았는대,
    // C#에서 제공하는 Collections.Generic 사용해보는 예시입니다.

    class CollectionsGenericGroup
    {
        class ListData // 게임을 플레이 할 때 유저가 갖고 데이터. 시작 전에는 데이터가 존재하지 않다가 회원가입, 게임 아이디를 만들고 나서
                       // 동적으로 생성되는 데이터들을 처리하기 위해 선언한 클래스.
                       // 외부에 있는 데이터(서버, 클라이언트 내부 데이터를 저장) 데이터를 읽어서 사용한다.
                       // 외부에서 데이터를 읽고 저장하는 방법 (향 후 유니티 배울 예정!)
        {
            private string name;
            private int number;

            public string Name
            {
                get => name;
                set => name = value;
            }

            public int Number
            {
                get => number;
                set => number = value;
            }
        }

        public void ListExample()
        {
            // int 데이터를 담는 가변배열을 선언
            List<int> list = new List<int>();
            
            for(int i=0; i< 5; i++)
            {
                list.Add(i);
            }

            foreach(int element in list)
            {
                Console.WriteLine($"List안의 요소 : {element}");
            }

            List<ListData> listDatas = new List<ListData>();

            //listDatas.Add();

        }

        // Queue : FIFO 방식으로 데이터를 저장하고 사용하는 자료구조입니다.
        // 저장할 데이터를 T로 선언해서, 모든 데이터 타입을 다룰 수 있게 됩니다.

        // 데이터를 순서대로 저장했다가 들어온 순서로 데이터를 내보낸다.
        // 게임에서 1~100마리 적게 나오는 게임도 있지만,
        // 엄청나게 많은 1만~10만 마리 게임도 있을 수 잇습니다.
        // GC-Alloc(쓰레기 데이터를 감지하고 삭제)
        // 게임오브젝트를 삭제를 할 때 마다 GC 데이터가 누적이 됩니다.
        // 게임오브젝트가 논리적으로 죽음(삭제)판정일 때 실제로 게임오브젝트를 삭제 하지 않고, 비활성화 상태로 다른 데이터에 저장하여 보관.
        
        // Stack 

        // Dictionary<Tkey, TValue>
        // HashTable의 일반화 버전입니다.
        // 형식 매개 변수를 두 개를 요구하는 자료 구조입니다.
        // TKey는 Hash 알고리즘에 Key를 저장하고 TValue Value 저장합니다.

        // 데이터를 관리하는 클래스.
        // 클래스를 호출하여 원하는 곳에다가 몬스터의 데이터를 추출하여 사용할 수 있게 되는 겁니다.
        public void DictionaryExample()
        {
            Dictionary<long, string> dic = new Dictionary<long, string>();

            // 실제 게임에서 사용되는 예시
            // value가 갖고있는 ID값을 -> long, ulong 

            // 몬스터 개별 클래스 내부에 데이터를 각자 보관하면, 향후에 데이터 관리가 어려워집니다.

            dic[1000] = "하나";
            dic[1001] = "둘";
            dic[1002] = "셋";

            foreach(var item in dic)
            {
                Console.WriteLine($"{item} 호출"); 
            }

        }
    }
}
