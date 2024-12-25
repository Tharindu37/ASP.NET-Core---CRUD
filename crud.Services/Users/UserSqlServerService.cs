using crud.DataAccess;
using crud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud.Services.Users
{
    public class UserSqlServerService : IUserRepository
    {
        private readonly ProductDbContext _context = new ProductDbContext();


        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
