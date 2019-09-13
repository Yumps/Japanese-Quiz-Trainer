using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manabu.Models
{
    public class Question
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<QuizQuestions> QuizQuestions { get; set; }

        public ICollection<AnswerKey> AnswerKeys { get; set; }
    }
}
