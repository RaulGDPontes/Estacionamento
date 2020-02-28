using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TesteEstacionamento.Models;

namespace TesteEstacionamento.Controllers
{
    public class ValorController : Controller
    {
        private readonly TesteEstacionamentoContext _context;

        public ValorController(TesteEstacionamentoContext context)
        {
            _context = context;
        }

        // GET: ValorModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Valores.ToListAsync());
        }

        // GET: ValorModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorModel = await _context.Valores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (valorModel == null)
            {
                return NotFound();
            }

            return View(valorModel);
        }

        // GET: ValorModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ValorModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,InicioVigencia,TerminoVigencia,ValorInicial,ValorAdicional")] ValorModel valorModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(valorModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(valorModel);
        }

        // GET: ValorModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorModel = await _context.Valores.FindAsync(id);
            if (valorModel == null)
            {
                return NotFound();
            }
            return View(valorModel);
        }

        // POST: ValorModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,InicioVigencia,TerminoVigencia,ValorInicial,ValorAdicional")] ValorModel valorModel)
        {
            if (id != valorModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(valorModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ValorModelExists(valorModel.Id))
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
            return View(valorModel);
        }

        // GET: ValorModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var valorModel = await _context.Valores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (valorModel == null)
            {
                return NotFound();
            }

            return View(valorModel);
        }

        // POST: ValorModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var valorModel = await _context.Valores.FindAsync(id);
            _context.Valores.Remove(valorModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ValorModelExists(int id)
        {
            return _context.Valores.Any(e => e.Id == id);
        }
    }
}
