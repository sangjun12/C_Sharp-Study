namespace Chapter03_1
{


    class knight //1. 설계도(기사 클래스)
    {
        public int hp = 0;
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    StartGame();
        //}

        static void StartGame()
        {
            // 지역 변수 선언 (값 형식)
            int damege = 10;

            // 객체 생성(참조 형식)
            knight k1 = new knight();

            // 데이터 할당
            k1.hp = 100;

            Console.WriteLine($"기사의 체력: {k1.hp}");
            Console.WriteLine($"공격력: {damege}");
        }
    }

}