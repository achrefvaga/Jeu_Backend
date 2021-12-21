using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface IRoom
    {

        public List<Room> GetRoom();

        public Room AddRoom(Room roomItem);

        public Room UpdateRoom(Room roomItem);

        public void DeleteRoom(int id);
    }
}
