using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Manabu.Data;
using Manabu.Models;
using Microsoft.AspNetCore.Authorization;
using Manabu.Models.ViewModels;

namespace Manabu.Controllers
{
    [Authorize]
    public class QuizsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Quiz
        public async Task<IActionResult> Index()
        {
            return View(await _context.Quizzes.ToListAsync());
        }

        // GET: Quizs/TakeQuiz/1
        public async Task<IActionResult> TakeQuiz(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicationDbContext = await _context.QuizQuestions
                .Include(q => q.Question)
                .ThenInclude(q => q.AnswerKeys)
                .Where(q => q.QuizId == id).ToListAsync();

            var questions = applicationDbContext.Select(q => q.Question);

            var answerList = await _context.AnswerKeys.ToListAsync();

            var answers = new List<int>();

            foreach(Question question in questions)
            {


                while(answers.Count() < 4)
                {
                var random = new Random();
                int index = random.Next(answerList.Count());
                question.AnswerKeys.Add(answerList[index]);


                int index2 = random.Next(answerList.Count());
                question.AnswerKeys.Add(answerList[index2]);


                int index3 = random.Next(answerList.Count());
                question.AnswerKeys.Add(answerList[index3]);
                }
            }

            return View(questions);
        }
    }
}
