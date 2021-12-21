using Test1312.DBContext;
using Test1312.Interfaces;
using Test1312.Model;

namespace Test1312.Repository
{
    public class QuestionRepo : IQuestion
    {

        private readonly DBContextTest _context;

        public QuestionRepo(DBContextTest context)
        {
            _context = context;
        }
        public Question AddQuestion(Question quesItem)
        {
            _context.Add(quesItem);
            _context.SaveChanges();

            return quesItem;
        }

        public void DeleteQuestion(int id)
        {
            var question = _context.Questions.FirstOrDefault(u => u.questionId == id);
            _context.Questions.Remove(question);
            _context.SaveChanges();
        }

        public List<Question> GetQuestion()
        {
            return _context.Questions.ToList();
        }

        public Question UpdateQuestion(Question quesItem)
        {
            _context.Update(quesItem);
            _context.SaveChanges();
            return quesItem;
        }
    }
}
