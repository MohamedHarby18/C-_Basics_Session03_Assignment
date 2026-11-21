using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        //string title = "clean code";
        //string upperTitle = title.ToUpper();
        //Console.WriteLine(title);
        //Console.WriteLine(upperTitle);
        //.................................//

        //string str1 = "Clean Code";
        //string str2 = "Clean Code";
        //bool result = ReferenceEquals(str1, str2);
        //Console.WriteLine(result);
        //.................................//

        StringBuilder bookList = new StringBuilder();
        bookList.Append("Book List");
        bookList.Append(" Updated");
        Console.WriteLine(bookList);
    }
}