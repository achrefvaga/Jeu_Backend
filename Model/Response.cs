using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test1312.Model
{
    public class Response
    {
        [Key]
        public int responseId { get; set; }
        public string res_content { get; set; }
        public int score { get; set; }


        public int id_question { get; set; }
      
        public  Question? questions { get; set; }

    }
}
