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
    public class QuizzesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuizzesController(ApplicationDbContext context)
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


            foreach(Question question in questions)
            {
            var answersIndex = new List<int>();
              var correctAnswerIndex = answerList.FindIndex(a=>a.Id == question.AnswerKeys.ToList()[0].Id);
                answersIndex.Add(correctAnswerIndex);

                var random = new Random();

                while (answersIndex.Count() < 4)
                {
                    //generate random number in while loop, check if in answersIndex, if not add to answerIndex
                    var index = random.Next(answerList.Count());

                    if (!answersIndex.Contains(index))
                    {
                    answersIndex.Add(index);
                    }
                }
                //add question's answer based on the random number given in while loop
                question.AnswerKeys.Add(answerList[answersIndex[1]]);
                question.AnswerKeys.Add(answerList[answersIndex[2]]);
                question.AnswerKeys.Add(answerList[answersIndex[3]]);
                }

            return View(questions);
        }
    }
}
