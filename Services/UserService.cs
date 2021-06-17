using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Services
{
    public class UserService : IUserService
    {
        private User _user;
        public UserService(User user)
        {
            this._user = user;                
        }
        public List<Book> GetAllUserBooks()
        {
            if(_user != null)
            {
                return _user.UsersBooks;
            }
            return null;
        }
    }
}
