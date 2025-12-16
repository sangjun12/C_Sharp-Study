namespace Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';
            Console.WriteLine("Char : ");
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);

            Console.WriteLine();
            Console.WriteLine("string : ");
            string f = "안녕하세요?";
            Console.WriteLine(f);

            // string multiline = "첫 번째 줄\n두 번째 줄\n세 번째 줄";
            // Console.WriteLine(multiline);

            string multiline = """
                첫 번째 줄
                두 번째 줄

                세 번째 줄
                """;
            Console.WriteLine(multiline);

        }
    }
}
