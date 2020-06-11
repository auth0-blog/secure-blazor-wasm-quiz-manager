using QuizManagerClientHosted.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace QuizManagerClientHosted.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuizController : ControllerBase
    {
        private static readonly List<QuizItem> Quiz = new List<QuizItem> {
            new QuizItem
                {
                    Question = "Which of the following is the name of a Leonardo da Vinci's masterpiece?",
                    Choices = new List<string> {"Sunflowers", "Mona Lisa", "The Kiss"},
                    AnswerIndex = 1,
                    Score = 3
                },
                new QuizItem
                {
                    Question = "Which of the following novels was written by Miguel de Cervantes?",
                    Choices = new List<string> {"The Ingenious Gentleman Don Quixote of La Mancia", "The Life of Gargantua and of Pantagruel", "One Hundred Years of Solitude"},
                    AnswerIndex = 0,
                    Score = 5
                }
            };

        [HttpGet]
        public List<QuizItem> Get()
        {
            return Quiz;
        }
    }
}
