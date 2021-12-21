using System.ComponentModel.DataAnnotations;

namespace Test1312.Model
{
    public class User
    {
        [Key]
        public int userId { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public ICollection<Participation>? Participations  { get; set; }  
    }
}
    