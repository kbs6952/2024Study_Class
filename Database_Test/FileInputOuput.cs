using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Test
{
    internal class FileInputOuput
    {
        // File, Directory(Folder), Stream 개념을 학습하도록 하겠습니다.

        // Stream 스트림
        // 시간의 흐름에 따라 연속적으로 발생하는 데이터의 흐름을 뜻합니다.
        // IO. 저장하고 불러올 때 사용을 하는 클래스이름. 스트림이 연결되있어야 합니다.

        // 파일 읽기
        void ReadStream()
        {
            // 윈도우 file directory 구조를 한번 보시면

            string data;
            StreamReader reader = new StreamReader(@"C:\Sample.test.txt");

            data = reader.ReadLine();

            while(data != null)
            {
                data = reader.ReadLine();
            }

            reader.Close();
        }

        void WrieStream()
        {
            StreamWriter writer = new StreamWriter(@"C:\Sample.test.txt");

            writer.WriteLine("여기에는 테스트 데이터가 들어갈겁니다.");

            writer.Close();
        }

    }
}
