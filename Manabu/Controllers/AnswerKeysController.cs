using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Manabu.Data;
using Manabu.Models;

namespace Manabu.Controllers
{
    public class AnswerKeysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnswerKeysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AnswerKeys
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AnswerKeys.Include(a => a.Question);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AnswerKeys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerKey = await _context.AnswerKeys
                .Include(a => a.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answerKey == null)
            {
                return NotFound();
            }

            return View(answerKey);
        }

        // GET: AnswerKeys/Create
        public IActionResult Create()
        {
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id");
            return View();
        }

        // POST: AnswerKeys/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,QuestionId")] AnswerKey answerKey)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answerKey);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id", answerKey.QuestionId);
            return View(answerKey);
        }

        // GET: AnswerKeys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerKey = await _context.AnswerKeys.FindAsync(id);
            if (answerKey == null)
            {
                return NotFound();
            }
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id", answerKey.QuestionId);
            return View(answerKey);
        }

        // POST: AnswerKeys/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,QuestionId")] AnswerKey answerKey)
        {
            if (id != answerKey.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answerKey);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerKeyExists(answerKey.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestionId"] = new SelectList(_context.Questions, "Id", "Id", answerKey.QuestionId);
            return View(answerKey);
        }

        // GET: AnswerKeys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerKey = await _context.AnswerKeys
                .Include(a => a.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (answerKey == null)
            {
                return NotFound();
            }

            return View(answerKey);
        }

        // POST: AnswerKeys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answerKey = await _context.AnswerKeys.FindAsync(id);
            _context.AnswerKeys.Remove(answerKey);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerKeyExists(int id)
        {
            return _context.AnswerKeys.Any(e => e.Id == id);
        }
    }
}
