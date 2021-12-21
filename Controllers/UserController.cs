using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;
using Test1312.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUser _user;

        public UserController(IUser user)
        {
            _user = user;
        }
        // GET: api/<UserController>
         [HttpGet]
          public ActionResult<List<User>> GetUser()
          {
             return  _user.GetUsers();
          } 

        // POST api/<UserController>
        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            _user.AddUser(user);
            return user;
        }

        // PUT api/<UserController>/5
       [HttpPut("{id}")]
         public ActionResult<User>UpdateUser(User user)
            {
                _user.UpdateUser( user);
                    return user; ;
            }

            // DELETE api/<UserController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            _user.DeleteUser(id);
            }
    }
}
