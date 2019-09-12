using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manabu.Models
{
    public class QuizQuestions
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
