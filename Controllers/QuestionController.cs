using Microsoft.AspNetCore.Mvc;
using Test1312.Interfaces;
using Test1312.Model;
using Test1312.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test1312.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private IQuestion _ques;

        public QuestionController(IQuestion ques)
        {
            _ques = ques;
        }
       
        [HttpGet]
        public ActionResult<List<Question>> GetQuestion()
        {
            return _ques.GetQuestion();
        }

        
        [HttpPost]
        public ActionResult<Question> CreateQuestion(Question ques)
        {
            _ques.AddQuestion(ques);
            return ques;
        }

        
        [HttpPut("{id}")]
        public ActionResult<Question> UpdateQuestion(Question ques)
        {
            _ques.UpdateQuestion(ques);
            return ques; ;
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ques.DeleteQuestion(id);
        }
    }
}
