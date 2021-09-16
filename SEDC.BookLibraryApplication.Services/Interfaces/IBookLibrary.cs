using SEDC.BookLibraryApplication.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.BookLibraryApplication.Services.Interfaces
{
    public interface IBookLibrary
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        void AddBook(Book book);

        void UpdateBook(Book book);

        void DeleteBook(int id);
    }
}
