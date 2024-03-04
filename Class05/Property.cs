using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05
{
    class Property
    {
        // 프로퍼티 사용 이유 : 은닉화를 배웠습니다. 은닉화를 유지하기 위해 private 필드를 선언을 할려고 하는데..
        // private 선언을 해야하는 이유는 알겠는대.. public으로 만들면 편하다.. 

        private string name;
        public string name2;

        public string SetName(string _name)
        {
            return name = _name;
        }
        public string GetName()
        {
            return name;
        }
        //public string Name { get { return name; } set { name = value; } }
        
        // 람다식 
       
        public string Name
        {
            get => name;
            set => name = value;
        }

        static void MainTest()
        {
            Property property = new Property();
            property.SetName("이름");
            property.name2 = "이름";
            property.Name = "이름"; 
        }

    }
}
