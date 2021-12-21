using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private IRoom _room;

        public RoomController(IRoom room)
        {
            _room = room;
        }
        // GET: api/<RoomController>
        [HttpGet]
        public ActionResult<List<Room>> GetRoom()
        {
            return _room.GetRoom();
        }

        // POST api/<RoomController>
        [HttpPost]
        public ActionResult<Room> CreateRoom(Room room)
        {
            _room.AddRoom(room);
            return room;
        }

        // PUT api/<RoomController>/5
        [HttpPut("{id}")]
        public ActionResult<Room> UpdateRoom(Room room)
        {
            _room.UpdateRoom(room);
            return room;
        }

        // DELETE api/<RoomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _room.DeleteRoom(id);        }
    }
}
