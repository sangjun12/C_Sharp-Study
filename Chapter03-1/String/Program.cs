using static System.Console;


namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //StringSearch
            string greeting = "Good Morning.";
            WriteLine("StringSearch");
            WriteLine(greeting);
            WriteLine();

            // IndexOf() 찾으려하는 문자열의 첫번째 위치
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));

            //LastIndexOf() 찾으려하는 문자열중 가장 뒤에 있는것에 위치
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));

            //StartsWith() 특정 문자열로 시작하는지 검사
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            //EndsWith() 특정 문자열로 끝나는지 검사
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            //Contains() 특정 문자열을 포함하는지 검사
            WriteLine("Contains 'Evening' : {0}", greeting.EndsWith("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            //Replace() 특정문자열 교체
            WriteLine("Relaced 'Morning' with 'Evening': {0}",
                greeting.Replace("Morning", "Evening"));

            WriteLine();
            WriteLine();

            //StiringModify

            WriteLine("StringModify");
            //소문자반환
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            //대문자변환
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());
            //삽입
            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            //삭제
            WriteLine("Remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

            //공백 제거
            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());

            WriteLine();
            WriteLine();

            //StringSlice

            WriteLine("StringSlice");
            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);

        }
    }
}
