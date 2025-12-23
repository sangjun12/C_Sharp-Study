namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue); // False
            Console.WriteLine(a != null);   

            a = 3;
            Console.WriteLine(a.HasValue); // True
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);    // 3
        }
    }
}
