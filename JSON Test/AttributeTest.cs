using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Test
{
    [History("김동훈", Version = 1.00, ChangeValue = "Old Method를 대체하는 새로운 method를 만들었다")]
    public class AttributeTest
    {
        // 애트리뷰트 : 코드에 대한 부가 정보를 저장하는 메타 데이터에 내용을 기록하고 읽을 수 있도록 하는 기능
        // 기본 적인 학습 목표 : 메타 데이터에 애트리뷰트를 사용하여 정보를 저장하고 그것을 리플렉션으로 읽어오는 것을 학습한다.

        // 주석과 애트리뷰트의 차이점이 무엇일까?

        // 주석 : 사람이 읽고 쓰는 정보를 입력하는 방식
        // 애트리뷰트 : 사람이 작성하고 컴퓨터(컴파일러)가 읽는 정보입니다.

        // 컴퓨터가 정보를 읽어서 어디에 사용하는가?

        // 1. obsolete 애트리뷰트 : 이 애트리뷰트가 선언된 멤버는 사용을 할 때 경고, 에러를 발생시키게 합니다.
        [Obsolete]
        public void OldMethod()
        {

        }

        public void NewMethod()
        {

        }

        // 2. 애트리뷰트 우리가 직접 만들어 본다.

        public class History : System.Attribute
        {
            private string name;
            public string Name => name;

            public double Version
            {
                get;
                set;
            }

            public string ChangeValue
            {
                get;
                set;
            }

            public History(string name)
            {
                this.name = name;
                Version = 1.0;
                ChangeValue = "Default Value";
            }
        }
    }
}
