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

        //StringBuilder bookList = new StringBuilder();
        //bookList.Append("Book List");
        //bookList.Append(" Updated");
        //Console.WriteLine(bookList);
        //.................................//

        //bookList.Replace("Book List", "Library");
        //Console.WriteLine(bookList);
        //................................//

        //string title = "Clean Code";
        //int pages = 464;
        //Console.WriteLine("Book : " + title + " Pages : " + pages);
        //.................................//

        //Console.WriteLine($"Book : {title} Pages : {pages}");
        //.................................//

        //string result = string.Format("Book : {0} Pages : {1}", title, pages);
        //Console.WriteLine(result);
        //.................................//

        //int pages = 464;

        //if (pages > 300)
        //    Console.WriteLine("Long Book");
        //else
        //    Console.WriteLine("Short Book");
        //.................................//

        //int pages = 464;
        //bool isAvailable = true;

        //if (pages > 300 && isAvailable)
        //    Console.WriteLine("You can borrow this book");
        //..................................//

        //string title = "Refactoring";
        //switch(title)
        //{
        //    case "Clean Code":
        //        Console.WriteLine("Great choice!");
        //        break;
        //    case "Refactoring":
        //        Console.WriteLine("Nice pick!");
        //        break;
        //    default:
        //        Console.WriteLine("Never heard of it");
        //        break;
        //}
        //.................................//

        //int pages = 464;
        //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        //Console.WriteLine(sizeLabel);
        //.................................//

        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //for (int i = 0; i < books.Length; i++)
        //{
        //    Console.WriteLine($"{i + 1}. {books[i]}");
        //}

        //int j= 0;
        //while (j < books.Length)
        //{
        //    Console.WriteLine($"{j + 1}. {books[j]}");
        //    j++;
        //}
        //.................................//

        //int k = 0;
        //do
        //{
        //    Console.WriteLine("Checking book...");
        //    k++;
        //} while (k < 3);
        //.................................//

        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //foreach (string book in books)
        //{
        //    Console.WriteLine(book);
        //}
        //.................................//

        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "Refactoring")
        //        break;
        //    Console.WriteLine(books[i]);
        //}
        ////.................................//
        //for (int i = 0; i < books.Length; i++)
        //{
        //    if (books[i] == "The Pragmatic Programmer")
        //        continue;
        //    Console.WriteLine(books[i]);
        //}
        //.................................//

        //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        //string[] books1 = {  };

        //PrintFirstBook(books);
        //Console.WriteLine("\n................\n");
        //PrintFirstBook(books1);

    }
    //public static void PrintFirstBook(string[] books)
    //{
    //    if (books.Length == 0)
    //    {
    //        return;
    //    }
    //    Console.WriteLine(books[0]);
    //}
}