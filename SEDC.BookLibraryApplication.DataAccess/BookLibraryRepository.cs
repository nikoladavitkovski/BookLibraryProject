using SEDC.BookLibraryApplication.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.BookLibraryApplication.DataAccess
{
    public class BookLibraryRepository : IRepository<Book>
    {
        public void Delete(int id)
        {
            Book book = StaticDb.Books.FirstOrDefault(x => x.BookId == id);
            StaticDb.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            return StaticDb.Books;
        }

        public Book GetById(int id)
        {
            Book book = StaticDb.Books.FirstOrDefault(x => x.BookId == id);
            return book;
        }

        public void Insert(Book book)
        {
            StaticDb.Books.Add(book);
        }

        public void Update(Book book)
        {
           Book book1 =  StaticDb.Books.FirstOrDefault(x => x.BookId == book.BookId);
            if(book1 == null)
            {
                throw new Exception("The book does not exist.");
            }
            int index = StaticDb.Books.IndexOf(book1);
            StaticDb.Books[index] = book1;
        }
    }
}
