using Library.Models;
using Library.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("/all")]
        public ActionResult<List<Book>> GetUserBooks()
        {
            List<Book> userBooks =  _userService.GetAllUserBooks();

            if (userBooks != null)
            {
                return Ok(userBooks);
            }

            return NotFound();
        }
    }
}
