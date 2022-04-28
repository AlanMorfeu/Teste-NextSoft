using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TesteNextSoftMVC.Models;

namespace TesteNextSoftMVC.Controllers
{
    public class FamiliaController : Controller
    {
        private readonly Context _context;

        public FamiliaController(Context context)
        {
            _context = context;
        }

        // GET: Familia
        public async Task<IActionResult> Index()
        {
            var context = _context.Familia.Include(f => f.Condominio);
            return View(await context.ToListAsync());
        }

        // GET: Familia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia
                .Include(f => f.Condominio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familia == null)
            {
                return NotFound();
            }

            return View(familia);
        }

        // GET: Familia/Create
        public IActionResult Create()
        {
            ViewData["Id_Condominio"] = new SelectList(_context.Condominio, "Id", "Id");
            return View();
        }

        // POST: Familia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Id_Condominio,Apto,AreaApto,FracaoIdeal,ValorIPTU_Proporcional")] Familia familia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(familia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id_Condominio"] = new SelectList(_context.Condominio, "Id", "Id", familia.Id_Condominio);
            return View(familia);
        }

        // GET: Familia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia.FindAsync(id);
            if (familia == null)
            {
                return NotFound();
            }
            ViewData["Id_Condominio"] = new SelectList(_context.Condominio, "Id", "Id", familia.Id_Condominio);
            return View(familia);
        }

        // POST: Familia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Id_Condominio,Apto,AreaApto,FracaoIdeal,ValorIPTU_Proporcional")] Familia familia)
        {
            if (id != familia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(familia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FamiliaExists(familia.Id))
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
            ViewData["Id_Condominio"] = new SelectList(_context.Condominio, "Id", "Id", familia.Id_Condominio);
            return View(familia);
        }

        // GET: Familia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var familia = await _context.Familia
                .Include(f => f.Condominio)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (familia == null)
            {
                return NotFound();
            }

            return View(familia);
        }

        // POST: Familia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var familia = await _context.Familia.FindAsync(id);
            _context.Familia.Remove(familia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FamiliaExists(int id)
        {
            return _context.Familia.Any(e => e.Id == id);
        }
    }
}
