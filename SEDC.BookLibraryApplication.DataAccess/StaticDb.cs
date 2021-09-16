using SEDC.BookLibraryApplication.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BookLibraryApplication.DataAccess
{
    public class StaticDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                BookId = 95678,
                Title = "The Lord Of The Rings",
                Author = "J.R.R. Tolkien"
            },
            new Book()
            {
                BookId = 78956,
                Title = "The Adventures Of Harry Potter",
                Author = "J.K.Rowling"
            },
            new Book()
            {
                BookId = 37958,
                Title = "The Adventures Of Huckleberry Finn",
                Author = "Mark Twain"
            },
            new Book()
            {
                BookId = 87956,
                Title = "Sherlock Holmes",
                Author = "Arthur Conan Doyle"
            },
            new Book()
            {
                BookId = 67985,
                Title = "Great Expectations",
                Author = "Charles Dickens"
            }
        };
    }
}
