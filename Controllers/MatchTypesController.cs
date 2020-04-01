using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SRHLStats2020.Data;
using SRHLStats2020.Models.DataModels;

namespace SRHLStats2020.Controllers
{
    public class MatchTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MatchTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MatchTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.MatchType.ToListAsync());
        }

        // GET: MatchTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchType = await _context.MatchType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchType == null)
            {
                return NotFound();
            }

            return View(matchType);
        }

        // GET: MatchTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MatchTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MatchTypeName")] MatchType matchType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(matchType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(matchType);
        }

        // GET: MatchTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchType = await _context.MatchType.FindAsync(id);
            if (matchType == null)
            {
                return NotFound();
            }
            return View(matchType);
        }

        // POST: MatchTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MatchTypeName")] MatchType matchType)
        {
            if (id != matchType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(matchType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MatchTypeExists(matchType.Id))
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
            return View(matchType);
        }

        // GET: MatchTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var matchType = await _context.MatchType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (matchType == null)
            {
                return NotFound();
            }

            return View(matchType);
        }

        // POST: MatchTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var matchType = await _context.MatchType.FindAsync(id);
            _context.MatchType.Remove(matchType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MatchTypeExists(int id)
        {
            return _context.MatchType.Any(e => e.Id == id);
        }
    }
}
