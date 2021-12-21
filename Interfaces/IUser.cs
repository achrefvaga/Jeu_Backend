using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface  IUser
    {
        public List<User> GetUsers();

        public User AddUser(User userItem);

        public User UpdateUser( User userItem);

         public void DeleteUser(int id);
    }
}
