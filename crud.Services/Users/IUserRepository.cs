using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Users
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public List<User> GetAllUsers(string type, string search);
    }
}
