using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle(Book book)
        {
            return book?.Title ?? "Not Found";
        }

        public static string GetAuthors(Book book)
        {

            if (book == null) return "Error";

            string BookAuthors = string.Empty;

            foreach (string Author in book.Authors)
                BookAuthors += $"{Author}, ";

            return BookAuthors ?? "Not Found";
        }

        public static string GetPrice(Book book)
        {
            if (book == null) return "Error";

            return book?.Price.ToString() ?? "Not Found";
        }

    }
}
