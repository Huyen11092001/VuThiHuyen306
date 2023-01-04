using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VuThiHuyen306.Models;

namespace VuThiHuyen306.Controllers
{
    public class CompanyVTH306Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public CompanyVTH306Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: CompanyVTH306
        public async Task<IActionResult> Index()
        {
              return _context.CompanyVTH306 != null ? 
                          View(await _context.CompanyVTH306.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbcontext.CompanyVTH306'  is null.");
        }

        // GET: CompanyVTH306/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyVTH306 == null)
            {
                return NotFound();
            }

            var companyVTH306 = await _context.CompanyVTH306
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVTH306 == null)
            {
                return NotFound();
            }

            return View(companyVTH306);
        }

        // GET: CompanyVTH306/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyVTH306/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyVTH306 companyVTH306)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyVTH306);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyVTH306);
        }

        // GET: CompanyVTH306/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyVTH306 == null)
            {
                return NotFound();
            }

            var companyVTH306 = await _context.CompanyVTH306.FindAsync(id);
            if (companyVTH306 == null)
            {
                return NotFound();
            }
            return View(companyVTH306);
        }

        // POST: CompanyVTH306/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyVTH306 companyVTH306)
        {
            if (id != companyVTH306.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyVTH306);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyVTH306Exists(companyVTH306.CompanyId))
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
            return View(companyVTH306);
        }

        // GET: CompanyVTH306/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyVTH306 == null)
            {
                return NotFound();
            }

            var companyVTH306 = await _context.CompanyVTH306
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyVTH306 == null)
            {
                return NotFound();
            }

            return View(companyVTH306);
        }

        // POST: CompanyVTH306/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyVTH306 == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.CompanyVTH306'  is null.");
            }
            var companyVTH306 = await _context.CompanyVTH306.FindAsync(id);
            if (companyVTH306 != null)
            {
                _context.CompanyVTH306.Remove(companyVTH306);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyVTH306Exists(string id)
        {
          return (_context.CompanyVTH306?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
