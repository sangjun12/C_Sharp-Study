using System;

namespace Chapter05_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("현재 기온을 입력하세요: ");
            string input = Console.ReadLine();
            int temperature = int.Parse(input);
            Console.WriteLine($"현재 기온은 {temperature}도 입니다.");

            if (temperature >= 30)
            {
                Console.WriteLine("오늘은 매우 더운 날씨입니다. 외출 시 가벼운 옷차림을 권장합니다.");
            }

            else if (temperature >= 20)
            {
                Console.WriteLine("따뜻한 날씨입니다. ");
            }

            else if(temperature >= 10)
            {
                Console.WriteLine("선선한 날씨입니다. 가벼운 겉옷을 챙기세요.");
            }
            else  
            {
                Console.WriteLine("쌀쌀한 날씨입니다. 외출 시 따뜻한 옷차림을 권장합니다.");
            }
            
        }
    }
}
