using System.ComponentModel.DataAnnotations;

namespace Test1312.Model
{
    public class Question
    {   [Key]
        public int questionId { get; set; }
        public string ques_content { get; set; }
        public string language { get; set; }

        public ICollection<Selection>? selections { get; set; }
        public virtual Response? responses { get; set; }
    }
}
