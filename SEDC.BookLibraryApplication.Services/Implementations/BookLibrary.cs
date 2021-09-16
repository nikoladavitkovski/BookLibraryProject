using SEDC.BookLibraryApplication.DataAccess;
using SEDC.BookLibraryApplication.Domain;
using SEDC.BookLibraryApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.BookLibraryApplication.Services.Implementations
{
    public class BookLibrary : IBookLibrary
    {
        private IRepository<Book> _bookRepository;
        public BookLibrary()
        {
            _bookRepository = new BookLibraryRepository();
        }
        public void AddBook(Book book)
        {
            _bookRepository.Insert(book);
        }

        public void DeleteBook(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> GetAllBooks()
        {
            return _bookRepository.GetAll();
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.Update(book);
        }
    }
}
