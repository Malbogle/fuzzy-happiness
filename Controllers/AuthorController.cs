using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    [Route("api/author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            this._authorService = authorService;
        }

        [HttpGet("{author}")]
        public async Task<ActionResult<Author>> Get(string author)
        {
            Author curAuthor = await _authorService.GetAuthor(author);
            
            if(curAuthor != null)
            {
                return Ok(curAuthor);
            }

            return NotFound();
        }

    
    }
}
