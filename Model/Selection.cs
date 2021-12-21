using System.ComponentModel.DataAnnotations;

namespace Test1312.Model
{
    public class Selection
    {  
        [Key]
        public int selectionid { get; set; }

        public int idroom { get; set; }
        public Room? Room { get; set; }

        public int idquestion { get; set; }

        public Question? Question { get; set; }
    }
}
