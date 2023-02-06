using SampleForum.Entities;

namespace SampleForum.Repositoies
{
    public interface IQuestionsRepository
    {
        List<Question> GetQuestions();
        public void UpdateQuestion(Question question);
    }
}
