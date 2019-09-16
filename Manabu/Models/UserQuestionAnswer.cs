using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manabu.Models
{
    public class UserQuestionAnswer
    {
        public int Id { get; set; }
        public int AnswerId { get; set; }
        public AnswerKey AnswerKey { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
