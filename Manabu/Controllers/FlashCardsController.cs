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
using Microsoft.AspNetCore.Identity;

namespace Manabu.Controllers
{
    [Authorize]
    public class FlashCardsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public FlashCardsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: FlashCards
        public async Task<IActionResult> Index()
        {
            var user = await GetUserASync();
            var applicationDbContext = _context.FlashCards.Where(f => f.UserId == user.Id).Include(f => f.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: FlashCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlashCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Question,Answer")] FlashCard flashCard)
        {
            if (ModelState.IsValid)
            {
                var user = await GetUserASync();
                flashCard.UserId = user.Id;
                _context.Add(flashCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(flashCard);
        }

        // GET: FlashCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flashCard = await _context.FlashCards.FindAsync(id);
            if (flashCard == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", flashCard.UserId);
            return View(flashCard);
        }

        // POST: FlashCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Question,Answer,UserId")] FlashCard flashCard)
        {
            if (id != flashCard.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(flashCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FlashCardExists(flashCard.Id))
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
            ViewData["UserId"] = new SelectList(_context.ApplicationUsers, "Id", "Id", flashCard.UserId);
            return View(flashCard);
        }

        // GET: FlashCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var flashCard = await _context.FlashCards
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (flashCard == null)
            {
                return NotFound();
            }

            return View(flashCard);
        }

        // POST: FlashCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var flashCard = await _context.FlashCards.FindAsync(id);
            _context.FlashCards.Remove(flashCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FlashCardExists(int id)
        {
            return _context.FlashCards.Any(e => e.Id == id);
        }

        private Task<ApplicationUser> GetUserASync()
        {
            return _userManager.GetUserAsync(HttpContext.User);
        }

        private async Task<bool> WasCreatedByUser(FlashCard flashCard)
        {
            var user = await GetUserASync();
            return flashCard.UserId == user.Id;
        }
    }
}
