using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public delegate string BookFunctionsDelegate<T>(T book);
    internal class LibraryEngine
    {

        public static void ProcessBooks ( List<Book> bList, BookFunctionsDelegate<Book> fptr)
        {
            foreach (Book book in bList)
                Console.WriteLine(fptr(book));
        }

        public static void ProcessBooks(List<Book> bList, Func<Book , string> fptr)
        {
            foreach (Book book in bList)
                Console.WriteLine(fptr(book));
        }
    }
}
