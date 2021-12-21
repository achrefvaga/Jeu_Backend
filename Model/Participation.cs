using System.ComponentModel.DataAnnotations;

namespace Test1312.Model
{
    public class Participation
    {
        [Key]
        public int Idparticipation { get; set; }
        public int nb_kick { get; set; }

        public bool state { get; set; }
        public int userid { get; set; }
        public User ?User { get; set; }

        public int roomid { get; set; }
        public Room ?Room { get; set; }
    }
}
    