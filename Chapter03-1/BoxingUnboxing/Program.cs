namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a; // Boxing
            a += 1;
            int c = (int)b; // Unboxing

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            double x = 3.1414213;
            object y = x; // Boxing
            double z = (double)y; // Unboxing

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
