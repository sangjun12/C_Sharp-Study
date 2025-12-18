namespace StringNumberConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string b = a.ToString();
            Console.WriteLine(b);

            float c = 3.14159f;
            string d = c.ToString();
            Console.WriteLine(d);

            string e = "12345";
            int f = Convert.ToInt32(e);
            Console.WriteLine(f);

            string g = "3.14159";
            float h = float.Parse(g);
            Console.WriteLine(h);
        }
    }
}
