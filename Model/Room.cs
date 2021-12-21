using System.ComponentModel.DataAnnotations;

namespace Test1312.Model
{
    public class Room
    {
        [Key]
        public int roomId { get; set; }
        public int round { get; set; }
        public int draw_time { get; set; }
        public string language { get; set; }
        public string custom_words{ get; set; }
        public DateTime start_time { get; set; }

        public ICollection<Participation>? participations { get; set; }

        public ICollection<Selection>? selections { get; set; }

    }
}
