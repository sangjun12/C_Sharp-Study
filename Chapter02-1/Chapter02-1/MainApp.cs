using System; // System 네임스페이스를 가져옴
using static System.Console;  // System.Console 클래스의 정적 맴버를 전부 가져옴   

namespace Hello
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
        }
    }
}
