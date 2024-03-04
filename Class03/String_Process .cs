using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class03
{
    internal class String_Process
    {
        void FindTest()
        {
            // 문자열 찾기
            string world = "Hello World!";

            // indexOf
            Console.WriteLine("Indexof 'Hello': {0}", world.IndexOf("Hello"));

            // C# 6.0 이상 부터 문자열 보간이라는 기능을 지원해줍니다.

            Console.WriteLine($"Indexof 'Hello': {world.IndexOf("Hello")}");

            Console.WriteLine();
            // LastIndexOf

            // StartsWith

            // Contains

            string temp = "abcde";

            if (temp.Contains("abcde"))
            {
                // 어떠한 코드를 실행하라
            }

            // Replace

            temp.Replace("a", "f");

            // 문자열 변형하기

            // 문자열 분할하기
            // split, substring

        }


        void SS()
        {
            string a = "abcdefg";
            a = a.Substring(1);
            a = a.Substring(2, 4);

            // split

            string[] arr = null;
            string b = "안녕,하세요,반갑,습니다";
            arr = b.Split(',');
        }
        

        // 문자열 서식 맞추기
    }
}
