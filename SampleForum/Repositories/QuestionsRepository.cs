using SampleForum.Entities;
using SampleForum.Models;
using SampleForum.Repositoies;

namespace SampleForum.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        public List<Question> GetQuestions()
        {
            using(var dbContext = new DAL())
            {
                return dbContext.Questions.ToList();
            }
        }

        public void UpdateQuestion(Question question)
        {
            using(var dbContext = new DAL())
            {
                dbContext.Questions.Update(question);
            }
        
        }
    }
}
