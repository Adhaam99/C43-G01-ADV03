using Assignment;

namespace Asignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Book B01 = new Book("10" , "C++" , ["Adham" , "Yehia"] , new DateTime(2017 , 9 , 22) , 1000M );
            Book B02 = new Book("20", "Java", ["Khaled", "Ahmed"], new DateTime(2020 , 5 , 22), 3000M);

            List<Book> Books = [B01, B02];

            // 1

            BookFunctionsDelegate<Book> titleFunc = BookFunctions.GetTitle;

            LibraryEngine.ProcessBooks(Books, titleFunc);

            // 2

            Func<Book , string> authorsFunc = BookFunctions.GetAuthors;

            LibraryEngine.ProcessBooks(Books,   authorsFunc);

            // 3 

            Func<Book, string> isbnFunc = delegate (Book book) { return book?.ISBN ?? "Not Found"; };

            LibraryEngine.ProcessBooks(Books, isbnFunc);

            // 4

            Func<Book, string> publicationDateFunc = book => book.PublicationDate.ToString() ;

            LibraryEngine.ProcessBooks(Books, publicationDateFunc);

        }
    }
}
