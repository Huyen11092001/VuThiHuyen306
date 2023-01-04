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
    public class VTH0306Controller : Controller
    {
        private readonly ApplicationDbcontext _context;

        public VTH0306Controller(ApplicationDbcontext context)
        {
            _context = context;
        }

        // GET: VTH0306
        public async Task<IActionResult> Index()
        {
              return _context.VTH0306 != null ? 
                          View(await _context.VTH0306.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbcontext.VTH0306'  is null.");
        }

        // GET: VTH0306/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.VTH0306 == null)
            {
                return NotFound();
            }

            var vTH0306 = await _context.VTH0306
                .FirstOrDefaultAsync(m => m.VTHId == id);
            if (vTH0306 == null)
            {
                return NotFound();
            }

            return View(vTH0306);
        }

        // GET: VTH0306/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VTH0306/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VTHId,VTHName,VTHGender")] VTH0306 vTH0306)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vTH0306);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vTH0306);
        }

        // GET: VTH0306/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.VTH0306 == null)
            {
                return NotFound();
            }

            var vTH0306 = await _context.VTH0306.FindAsync(id);
            if (vTH0306 == null)
            {
                return NotFound();
            }
            return View(vTH0306);
        }

        // POST: VTH0306/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VTHId,VTHName,VTHGender")] VTH0306 vTH0306)
        {
            if (id != vTH0306.VTHId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vTH0306);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VTH0306Exists(vTH0306.VTHId))
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
            return View(vTH0306);
        }

        // GET: VTH0306/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.VTH0306 == null)
            {
                return NotFound();
            }

            var vTH0306 = await _context.VTH0306
                .FirstOrDefaultAsync(m => m.VTHId == id);
            if (vTH0306 == null)
            {
                return NotFound();
            }

            return View(vTH0306);
        }

        // POST: VTH0306/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.VTH0306 == null)
            {
                return Problem("Entity set 'ApplicationDbcontext.VTH0306'  is null.");
            }
            var vTH0306 = await _context.VTH0306.FindAsync(id);
            if (vTH0306 != null)
            {
                _context.VTH0306.Remove(vTH0306);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VTH0306Exists(string id)
        {
          return (_context.VTH0306?.Any(e => e.VTHId == id)).GetValueOrDefault();
        }
    }
}
