using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class09
{
    public class CollectionGroup
    {
        // Library에는 자료구조를 클래스로 구현을 해두었습니다.
        // 2가지 방식으로 구현을 했어요. 매개 변수로 Object 타입을 받는 클래스 자료구조 형태와
        // 일반화 프로그래밍(Generic)을 활용하여 <T> 자료구조를 구현한 클래스 형태

        // 1. Arraylist - List<T> 가변 배열

        public void Test()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("한글");
            arrayList.Add('c');
            arrayList.Add(0.5f);
            // 사용할 때는 편할 수는 있지만, boxing - unboxing이 발생하기 때문에 메모리 처리에 비용이 많이 들어간다.
            arrayList.Remove('c');

            foreach(var item in arrayList)
            {
                Console.WriteLine($"가변 배열 클래스에 들어있는 요소를 출력 : {item}");
            }

            // 스택 자료구조는 First in Last Out 데이터를 불러오는 논리 구조 형태를 갖고 있습니다.
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            // 큐 자료구조는 First in First out 데이터 불러오는 논리 구조 형태를 갖고 있습니다.
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while(queue.Count > 0)
                Console.WriteLine(queue.Dequeue());

            // Hashtable : Hashing 알고리즘, Hashing 함수를 통하여 데이터를 Pair class {Key와 Value} 관리하는 자료구조입니다.
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "하나");
            hashtable.Add(2, "둘");
            hashtable.Add(3, "셋");

            Console.WriteLine($"1번 키에 들어간 Value : {hashtable[1]}");

        }
    }
}
