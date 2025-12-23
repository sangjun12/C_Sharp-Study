namespace Enum
{
    internal class Program
    {

        enum DialogResult
        { YES, NO = 10, CANCEL = 9, CONFIRM, OK }

        static void Main(string[] args)
        {
            const int a = 3;
            Console.WriteLine("Const Example");
            Console.WriteLine(a);




            Console.WriteLine("Enum Example");
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);

        }
    }
   
}

