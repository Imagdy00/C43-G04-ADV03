namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Complete the Book Class
            //    public class Book
            //{
            //    public string ISBN { get; set; }
            //    public string Title { get; set; }
            //    public string[] Authors { get; set; }
            //    public DateTime PublicationDate { get; set; }
            //    public decimal Price { get; set; }

            //    public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
            //    {
            //        ISBN = _ISBN;
            //        Title = _Title;
            //        Authors = _Authors;
            //        PublicationDate = _PublicationDate;
            //        Price = _Price;
            //    }

            //    public override string ToString()
            //    {
            //        string authors = string.Join(", ", Authors);
            //        return $"ISBN: {ISBN}, Title: {Title}, Authors: {authors}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
            //    }
            //}
            #endregion


            #region Complete the BookFunctions Class
            //    public class BookFunctions
            //{
            //    public static string GetTitle(Book B)
            //    {
            //        return B.Title;
            //    }

            //    public static string GetAuthors(Book B)
            //    {
            //        return string.Join(", ", B.Authors);
            //    }

            //    public static string GetPrice(Book B)
            //    {
            //        return B.Price.ToString("C");
            //    }
            //}
            #endregion


            #region Implement the LibraryEngine Class with Different Delegates
            //    public class LibraryEngine
            //{

            //    public delegate string BookFunctionDelegate(Book B);


            //    public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
            //    {
            //        foreach (Book B in blist)
            //        {
            //            Console.WriteLine(fPtr(B));
            //        }
            //    }


            //    public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
            //    {
            //        foreach (Book B in blist)
            //        {
            //            Console.WriteLine(fPtr(B));
            //        }
            //    }
            //}
            #endregion



            #region Demonstrate Usage with Different Cases
        //    class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        List<Book> books = new List<Book>
        //{
        //    new Book("123-456", "C# Programming", new string[] { "John Doe", "Jane Smith" }, new DateTime(2020, 1, 1), 29.99m),
        //    new Book("789-012", "Advanced C#", new string[] { "Alice Johnson" }, new DateTime(2021, 5, 15), 49.99m)
        //};

                
        //        LibraryEngine.BookFunctionDelegate titleDelegate = BookFunctions.GetTitle;
        //        LibraryEngine.ProcessBooks(books, titleDelegate);

                
        //        Func<Book, string> authorsDelegate = BookFunctions.GetAuthors;
        //        LibraryEngine.ProcessBooks(books, authorsDelegate);

                
        //        LibraryEngine.BookFunctionDelegate isbnDelegate = delegate (Book B) { return B.ISBN; };
        //        LibraryEngine.ProcessBooks(books, isbnDelegate);

                
        //        Func<Book, string> pubDateDelegate = B => B.PublicationDate.ToShortDateString();
        //        LibraryEngine.ProcessBooks(books, pubDateDelegate);
        //    }
        //}
        #endregion
    }
    }
}
