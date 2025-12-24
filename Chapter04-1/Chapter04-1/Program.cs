namespace Chapter04_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a =  111 + 222;
            Console.WriteLine($"a : {a}");

            Console.WriteLine(a++);
            Console.WriteLine(++a);

            string result = "123" + "456";
            Console.WriteLine(result);

            Console.WriteLine($"3 > 4:{3 > 4}");
            Console.WriteLine($"3 >= 4:{3 >= 4}");
            Console.WriteLine($"3 < 4:{3 < 4}");
            Console.WriteLine($"3 != 4:{3 != 4}");


        }
    }
}
