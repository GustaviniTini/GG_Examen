using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GG_Examen.Data;
using GG_Examen.Models;

namespace GG_Examen.Controllers
{
    public class GGuevaraController : Controller
    {
        private readonly GG_ExamenContext _context;

        public GGuevaraController(GG_ExamenContext context)
        {
            _context = context;
        }

        // GET: GGuevara
        public async Task<IActionResult> Index()
        {
              return _context.GGuevara != null ? 
                          View(await _context.GGuevara.ToListAsync()) :
                          Problem("Entity set 'GG_ExamenContext.GGuevara'  is null.");
        }

        // GET: GGuevara/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.GGuevara == null)
            {
                return NotFound();
            }

            var gGuevara = await _context.GGuevara
                .FirstOrDefaultAsync(m => m.gg_Codigo == id);
            if (gGuevara == null)
            {
                return NotFound();
            }

            return View(gGuevara);
        }

        // GET: GGuevara/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GGuevara/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("gg_Codigo,gg_Nombre,gg_EnStock,gg_Precio,gg_FechaCaducidad,gg_CorreoClienteQueAdquirioProducto")] GGuevara gGuevara)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gGuevara);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gGuevara);
        }

        // GET: GGuevara/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.GGuevara == null)
            {
                return NotFound();
            }

            var gGuevara = await _context.GGuevara.FindAsync(id);
            if (gGuevara == null)
            {
                return NotFound();
            }
            return View(gGuevara);
        }

        // POST: GGuevara/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("gg_Codigo,gg_Nombre,gg_EnStock,gg_Precio,gg_FechaCaducidad,gg_CorreoClienteQueAdquirioProducto")] GGuevara gGuevara)
        {
            if (id != gGuevara.gg_Codigo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gGuevara);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GGuevaraExists(gGuevara.gg_Codigo))
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
            return View(gGuevara);
        }

        // GET: GGuevara/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.GGuevara == null)
            {
                return NotFound();
            }

            var gGuevara = await _context.GGuevara
                .FirstOrDefaultAsync(m => m.gg_Codigo == id);
            if (gGuevara == null)
            {
                return NotFound();
            }

            return View(gGuevara);
        }

        // POST: GGuevara/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.GGuevara == null)
            {
                return Problem("Entity set 'GG_ExamenContext.GGuevara'  is null.");
            }
            var gGuevara = await _context.GGuevara.FindAsync(id);
            if (gGuevara != null)
            {
                _context.GGuevara.Remove(gGuevara);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GGuevaraExists(int id)
        {
          return (_context.GGuevara?.Any(e => e.gg_Codigo == id)).GetValueOrDefault();
        }
    }
}
