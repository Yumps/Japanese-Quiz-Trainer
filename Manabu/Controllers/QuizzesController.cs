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
        public async Task<IActionResult> SaveAnswers([Bind("Id,CorrectAnswer")] IEnumerable<Question> question, int quizId)
        {
            foreach (Question questionResult in question)
            {
                if (questionResult.CorrectAnswer != 0 && questionResult.Id != 0)
                {
                    var user = await GetUserAsync();
                    var userAnswer = new UserQuestionAnswer
                    {
                        QuestionId = questionResult.Id,
                        AnswerKeyId = questionResult.CorrectAnswer,
                        UserId = user.Id
                    };
                    _context.Add(userAnswer);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(QuizResults), new { id = quizId});
            //return RedirectToAction(nameof(Index));
        }

        //GET: Quiz/QuizResults
        public async Task<IActionResult> QuizResults(int? id)
        {
            var user = await GetUserAsync();

            var quizResults = await _context.QuizQuestions
                .Include(q => q.Question)
                .ThenInclude(q => q.UserQuestionAnswers)
                .Where(q => q.QuizId == id).ToListAsync();

            var quizAnswers = await _context.QuizQuestions
                .Include(q => q.Question)
                .ThenInclude(q => q.AnswerKeys)
                .Where(q => q.QuizId == id).ToListAsync();

            var quiz = _context.Quizzes
                .Where(q => q.Id == id).FirstOrDefault();


            var uqaSelect = quizResults
            .Select(q => q.Question.UserQuestionAnswers.Where(u => u.UserId == user.Id).OrderByDescending(uqa => uqa.Id).First());

            var answerList = quizAnswers.Select(q => q.Question.AnswerKeys.ToList()[0]);

            var questionAnswerMatch = new List<AnswerKey>();

            foreach (UserQuestionAnswer uqa in uqaSelect)
            {
                var correctAnswer = answerList.Where(q => q.QuestionId == uqa.QuestionId && q.Id == uqa.AnswerKeyId).ToList();

                if(correctAnswer.Count() > 0)
                {
                    questionAnswerMatch.Add(correctAnswer[0]);
                }
            }
            var correctAnswerCount = questionAnswerMatch.Count();
            quiz.CorrectAnswers = correctAnswerCount;

            return View(quiz);
        }

        public Task<ApplicationUser> GetUserAsync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }
    }
}
