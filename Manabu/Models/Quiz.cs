﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Manabu.Models
{
    public class Quiz
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public virtual ICollection<QuizQuestions> QuizQuestions { get; set; }
        public virtual ICollection<AnswerKey> AnswerKeys { get; set; }
    }
}
