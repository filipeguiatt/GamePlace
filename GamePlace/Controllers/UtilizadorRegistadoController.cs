using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GamePlace.Data;
using GamePlace.Models;

namespace GamePlace.Controllers
{
    public class UtilizadorRegistadoController : Controller
    {
        private readonly GamePlaceContext _context;

        public UtilizadorRegistadoController(GamePlaceContext context)
        {
            _context = context;
        }

        // GET: UtilizadorRegistadoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UtilizadorRegistado.ToListAsync());
        }

        // GET: UtilizadorRegistadoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadorRegistado = await _context.UtilizadorRegistado
                .FirstOrDefaultAsync(m => m.IdUtilizador == id);
            if (utilizadorRegistado == null)
            {
                return NotFound();
            }

            return View(utilizadorRegistado);
        }

        // GET: UtilizadorRegistadoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UtilizadorRegistadoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUtilizador,Nome,Morada,CodPostal,Telemovel,Email")] UtilizadorRegistado utilizadorRegistado)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utilizadorRegistado);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utilizadorRegistado);
        }

        // GET: UtilizadorRegistadoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadorRegistado = await _context.UtilizadorRegistado.FindAsync(id);
            if (utilizadorRegistado == null)
            {
                return NotFound();
            }
            return View(utilizadorRegistado);
        }

        // POST: UtilizadorRegistadoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUtilizador,Nome,Morada,CodPostal,Telemovel,Email")] UtilizadorRegistado utilizadorRegistado)
        {
            if (id != utilizadorRegistado.IdUtilizador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utilizadorRegistado);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtilizadorRegistadoExists(utilizadorRegistado.IdUtilizador))
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
            return View(utilizadorRegistado);
        }

        // GET: UtilizadorRegistadoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utilizadorRegistado = await _context.UtilizadorRegistado
                .FirstOrDefaultAsync(m => m.IdUtilizador == id);
            if (utilizadorRegistado == null)
            {
                return NotFound();
            }

            return View(utilizadorRegistado);
        }

        // POST: UtilizadorRegistadoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utilizadorRegistado = await _context.UtilizadorRegistado.FindAsync(id);
            _context.UtilizadorRegistado.Remove(utilizadorRegistado);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtilizadorRegistadoExists(int id)
        {
            return _context.UtilizadorRegistado.Any(e => e.IdUtilizador == id);
        }
    }
}
