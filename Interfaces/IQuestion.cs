using Test1312.Model;

namespace Test1312.Interfaces
{
    public interface IQuestion
    {
        public List<Question> GetQuestion();

        public Question AddQuestion(Question quesItem);

        public Question UpdateQuestion(Question quesItem);

        public void DeleteQuestion(int id);
    }
}
