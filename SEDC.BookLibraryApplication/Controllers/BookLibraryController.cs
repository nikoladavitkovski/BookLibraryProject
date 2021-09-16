using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDC.BookLibraryApplication.Domain;
using SEDC.BookLibraryApplication.Services.Implementations;
using SEDC.BookLibraryApplication.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.BookLibraryApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookLibraryController : ControllerBase
    {
        private IBookLibrary _bookLibrary;

        public BookLibraryController()
        {
            _bookLibrary = new BookLibrary();
        }

        [HttpGet]

        public ActionResult<List<Book>> Get()
        {
            return _bookLibrary.GetAllBooks();
        }
        [HttpGet("{id}")]

        public ActionResult<Book> Get(int id)
        {
            return _bookLibrary.GetBookById(id);
        }
        [HttpPost]

        public IActionResult Post([FromBody] Book book)
        {
            _bookLibrary.AddBook(book);
            return StatusCode(StatusCodes.Status201Created, "Book created!");
        }
        [HttpPut]

        public IActionResult Put([FromBody] Book book)
        {
            _bookLibrary.UpdateBook(book);
            return StatusCode(StatusCodes.Status204NoContent, "Book updated!");
        }
        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            _bookLibrary.DeleteBook(id);
            return StatusCode(StatusCodes.Status204NoContent, "Book deleted!");
        }
    }
}
