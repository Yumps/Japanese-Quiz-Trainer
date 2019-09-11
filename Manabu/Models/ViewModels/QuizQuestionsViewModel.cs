using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Manabu.Models.ViewModels
{
    public class QuizQuestionsViewModel
    {
        public int Id { get; set; }
        public Quiz Quiz { get; set; }
        public Question Question { get; set; }
    }
}
