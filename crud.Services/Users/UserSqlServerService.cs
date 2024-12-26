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

        public List<User> GetAllUsers(string type, string search)
        {
            if(string.IsNullOrWhiteSpace(type) && string.IsNullOrWhiteSpace(search))
            {
                return _context.Users.ToList();
            }

            var userCollection = _context.Users as IQueryable<User>;

            if (!string.IsNullOrWhiteSpace(type))
            {
                type = type.Trim();
                userCollection = userCollection.Where(u => u.Type == type);
            }

            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.Trim();
                userCollection = userCollection.Where(u => u.Name.Contains(search) || u.City.Contains(search));
            }
       
                
            return userCollection.ToList();

        }

        public User AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return _context.Users.Find(user.Id);
        }
    }
}
