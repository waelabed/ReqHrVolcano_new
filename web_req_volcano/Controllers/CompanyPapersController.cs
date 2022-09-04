using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web_req_volcano.Models;

namespace web_req_volcano.Controllers
{
    public class CompanyPapersController : Controller
    {
        private readonly ReqHrVolcanoContext _context;

        public CompanyPapersController(ReqHrVolcanoContext context)
        {
            _context = context;
        }

        // GET: CompanyPapers
        public async Task<IActionResult> Index()
        {
            var reqHrVolcanoContext = _context.CompanyPapers.Include(c => c.Papers);
            return View(await reqHrVolcanoContext.ToListAsync());
        }

        // GET: CompanyPapers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CompanyPapers == null)
            {
                return NotFound();
            }

            var companyPaper = await _context.CompanyPapers
                .Include(c => c.Papers)
                .FirstOrDefaultAsync(m => m.CompanyPapersId == id);
            if (companyPaper == null)
            {
                return NotFound();
            }

            return View(companyPaper);
        }

        // GET: CompanyPapers/Create
        public IActionResult Create()
        {
            ViewData["PapersId"] = new SelectList(_context.Papers, "PapersId", "PapersId");
            return View();
        }

        // POST: CompanyPapers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyPapersId,PapersId,CompanyPapersDate,CompanyPapersYear,CompanyPapersNote")] CompanyPaper companyPaper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyPaper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PapersId"] = new SelectList(_context.Papers, "PapersId", "PapersId", companyPaper.PapersId);
            return View(companyPaper);
        }

        // GET: CompanyPapers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CompanyPapers == null)
            {
                return NotFound();
            }

            var companyPaper = await _context.CompanyPapers.FindAsync(id);
            if (companyPaper == null)
            {
                return NotFound();
            }
            ViewData["PapersId"] = new SelectList(_context.Papers, "PapersId", "PapersId", companyPaper.PapersId);
            return View(companyPaper);
        }

        // POST: CompanyPapers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CompanyPapersId,PapersId,CompanyPapersDate,CompanyPapersYear,CompanyPapersNote")] CompanyPaper companyPaper)
        {
            if (id != companyPaper.CompanyPapersId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyPaper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyPaperExists(companyPaper.CompanyPapersId))
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
            ViewData["PapersId"] = new SelectList(_context.Papers, "PapersId", "PapersId", companyPaper.PapersId);
            return View(companyPaper);
        }

        // GET: CompanyPapers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CompanyPapers == null)
            {
                return NotFound();
            }

            var companyPaper = await _context.CompanyPapers
                .Include(c => c.Papers)
                .FirstOrDefaultAsync(m => m.CompanyPapersId == id);
            if (companyPaper == null)
            {
                return NotFound();
            }

            return View(companyPaper);
        }

        // POST: CompanyPapers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CompanyPapers == null)
            {
                return Problem("Entity set 'ReqHrVolcanoContext.CompanyPapers'  is null.");
            }
            var companyPaper = await _context.CompanyPapers.FindAsync(id);
            if (companyPaper != null)
            {
                _context.CompanyPapers.Remove(companyPaper);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyPaperExists(int id)
        {
          return (_context.CompanyPapers?.Any(e => e.CompanyPapersId == id)).GetValueOrDefault();
        }
    }
}
