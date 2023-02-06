using Microsoft.AspNetCore.Mvc;
using SampleForum.Entities;
using SampleForum.Repositoies;

namespace SampleForum.Controllers
{
    [Route("/api[controller]")]
    public class QuestionsController : Controller
    {
        private IQuestionsRepository questionsRepository;
        public QuestionsController(IQuestionsRepository questionsRepository)
        {
            this.questionsRepository = questionsRepository;
        }

        [HttpGet]
        public List<Question> GetQuestions() 
        { 
            List<Question>? questions= questionsRepository.GetQuestions();
            List<Question> result = questions.Select(q => new Question() {
            Id= q.Id,
            Title= q.Title,
            ShortDescription= q.ShortDescription,
            FullDescription= q.FullDescription,
            Date= q.Date,
            UserId= q.UserId,
            Username= q.Username,
            }).ToList();
            return result;
        }

        [HttpPut]
        public IActionResult UpdateQuestion(Question question) 
        {
            if(question == null) { return BadRequest(ModelState); }
            questionsRepository.UpdateQuestion(question);
            return Ok();
        }
    }
}
