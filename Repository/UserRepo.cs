using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class UserRepo : IUser
    {
 
        private readonly DBContextTest _context;

        public UserRepo(DBContextTest context)
        {
            _context = context; 
        }
        public User AddUser(User userItem)
        {
            _context.Add(userItem);
            _context.SaveChanges();
            
            return userItem;
        }

        public void DeleteUser(int id)
        {
           var user = _context.Users.FirstOrDefault(u=>u.userId == id);
            _context.Users.Remove(user);
            _context.SaveChanges();

        }

        public List<User> GetUsers()
        {
           return _context.Users.ToList();
        }

        public User UpdateUser( User userItem)
        {
            _context.Update(userItem);
            _context.SaveChanges();
            return userItem;
        }
    }
}
