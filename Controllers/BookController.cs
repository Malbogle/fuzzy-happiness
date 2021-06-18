

using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Library.Services;
using System.Threading.Tasks;


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

        [HttpGet("{book}")]
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
