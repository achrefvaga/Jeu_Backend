using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class RoomRepo : IRoom
    {
        private readonly DBContextTest _context;

        public RoomRepo(DBContextTest context)
        {
            _context = context;
        }
        public Room AddRoom(Room roomItem)
        {
            _context.Add(roomItem);
            _context.SaveChanges();

            return roomItem;
        }

        public void DeleteRoom(int id)
        {
            var room = _context.Rooms.FirstOrDefault(u => u.roomId == id);
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }

        public List<Room> GetRoom()
        {
            return _context.Rooms.ToList();
        }

        public Room UpdateRoom(Room roomItem)
        {
            _context.Update(roomItem);
            _context.SaveChanges();
            return roomItem;
        }
    }
}
