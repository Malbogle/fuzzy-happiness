

using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Library.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace Library.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        [HttpGet("all")]
        [Authorize]
        public ActionResult<List<Book>> GetAllUserBooks()
        {
            List<Book> usersBooks =  _bookService.GetAllUserBook();

            if (usersBooks != null)
            {
                return Ok(usersBooks);
            }

            return NotFound();
        }



        [HttpPost("save")]
        [Authorize]
        public async  Task<ActionResult<List<Book>>> SaveBook(string name)
        {
            Book bookToSave = await _bookService.SaveBook(name);
            if(bookToSave != null)
            {
                return Ok(bookToSave);
            }

            return NotFound();
        }

        [HttpGet("user/get")]
        [Authorize]
        public ActionResult<Book> GetUserBook(string book)
        {
            Book conBook =  _bookService.GetUserBook(book);

            if (conBook == null)
            {
                return NotFound();
            }
            return Ok(conBook);
        }

        [HttpGet("{book}")]
        [Authorize]
        public async Task<ActionResult<BookResults>> Get(string book)
        {
            BookResults conBook = await _bookService.GetBook(book);

            if (conBook == null)
            {
                return NotFound();
            }
            return Ok(conBook);
        }
    }

}
