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
using Microsoft.AspNetCore.Identity;

namespace Manabu.Controllers
{
    [Authorize]
    public class QuizzesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public QuizzesController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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


            foreach (Question question in questions)
            {
                var answersIndex = new List<int>();
                var correctAnswerIndex = answerList.FindIndex(a => a.Id == question.AnswerKeys.ToList()[0].Id);
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

        //POST User Answers
        //public async Task<IActionResult> Create([Bind("AnswerKey, QuestionId, UserId")] Question question)
        //{

        //    if(ModelState.IsValid)
        //    {
        //        var user = await GetUserAsync();
        //        question.UserId = user.Id;
        //        _context.Add(question);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(QuizResults));
        //    }
        //}

        public Task<ApplicationUser> GetUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
