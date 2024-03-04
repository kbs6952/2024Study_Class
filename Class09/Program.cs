namespace Class09
{
    // 9강
    // 학습 목표 : 배열과 컬렉션을 학습하고 일반화 프로그래밍의 필요성을 이해
    // 날짜 : 2024-02-21

    
    class Student // 학생의 이름과 점수를 저장하는 사용자 정의형 Student 클래스를 생성!
    {
        string name;
        int score;

        public Student(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("홍길동", 50);
            Student student2 = new Student("강감찬", 70);
            Student student3 = new Student("이순신", 80);
            Student student4 = new Student("장보고", 70);
            Student student5 = new Student("이성계", 70);
            //
            //학생이 10명이 있는 클래스다.
            // 1. 가독성에 좋지 않다.
            // 2. 데이터를 접근을 하려고 하니깐 각각의 클래스 객체를 찾아서 접근을 해야합니다.
            // 배열의 필요성을 이미 코드를 배우면서 학습을 하였습니다.

            // 배열의 기본 문법
            // 데이터 형식[] 배열이름 = new 데이터형식[크기]; 
            // 배열의 가장 큰 특징 : 배열은 선언할 때 자신의 크기를 반드시 초기화 해줘야 한다.
            // 배열은 <-> 가변배열. 처음 선언된 메모리의 크기를 바꿀 수 없다.

            Student[] studentGroup = new Student[10];

            // 데이터 크기를 먼저 선언한 후에 개별 데이터를 넣는 방법
            studentGroup[0] = student1;
            studentGroup[1] = student2;

            // 크기를 선언함과 동시에 데이터를 초기화 할 수도 있습니다.
            Student[] studentGroup2 = new Student[5]
            {
                student1, student2,student3, student4, student5
            };
            // 클래스 초기화를 통해서 배열의 크기를 선언하지 않고도 데이터 초기화로 배열을 초기화 할 수 있다/
            Student[] studentGroup3 = { student2, student3, student3 };

            // C# 컬렉션
            // 자료구조,컬렉션 : 같은 데이터 형식을 가독성이 있으면서, 데이터를 다루기 쉽게 하기 위해서 "자료구조, 컬렉션"을 사용한다.
            // 클래스 이론 -> 코드
            // 자료구조, 컬렉션을 구현을 해서.. 명확하게 이해 하는 방법 -> "자료 구조" 
            // 라이브러리에 있는 컬렉션을 꺼내서 사용하는 방법. 어떤 상황에 어느 컬렉션을 사용할지 판단력.

            // 자료구조. 
            // 분류 : 선형 자료구조, 비선형 자료구조
            // 선형 자료구조 : Array, List, Stack, Queue, Linked List
            // 비선형 자료구조 : 그래프, 트리

            // 선형 자료구조 -> Array, List, Linked List, Dictionary<T,V>  

            // 배열은 프로그램이 실행 도중에 배열의 크기를 변경할 수 없습니다.
            // 기존의 배열의 문제점을 해결하기 위해서 가변 배열 (List) 자료 구조가 등장하였습니다.

            // 연결 리스트 
            // 연결형 리스트는 : 노드에 자신의 앞 뒤 노드의 주소를 저장하는 클래스를 내부적으로 포함하고 있는 데이터들의 집합입니다
            // 장점 : 연결 리스트 중간에 있는 데이터를 추가하거나 삭제하기에 용이하다.
            // 단점 : 연결 리스트는 임의 접근을 할 수 없다. => 데이터를 색인(탐색) 시간이 오래 걸린다.

            // Hash, Dictionary
            // [Key - Value] 변수[Key] = Value; 
            // Key에 Value를 저장하여 데이터를 바로 접근할 수 있는 장점을 지닌 자료구조입니다.
            // Key와 Value의 데이터를 저장하기 위해 Hashing 비용이 발생하지만,
            // Key에 저장된 Value를 접근할 때 가장 빠르게 사용할 수 있습니다.

            Console.WriteLine("Hello, World!");

            Console.WriteLine("콜렉션 예시");

            CollectionGroup newGroup = new CollectionGroup();

            newGroup.Test();
        }
    }
}
