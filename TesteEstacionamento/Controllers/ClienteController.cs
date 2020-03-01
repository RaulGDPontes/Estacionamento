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
    public class ClienteController : Controller
    {
        private readonly TesteEstacionamentoContext _context;

        public ClienteController(TesteEstacionamentoContext context)
        {
            _context = context;
        }

        // GET: Cliente
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }

        // GET: Cliente/Details/5
        [HttpGet]
        public async Task<ClienteModel> Details(int? id)
        {
            if (id == null)
            {
                return null;
            }

            var clienteModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            clienteModel.DataSaida = DateTime.Now;

            if (clienteModel == null)
            {
                return null;
            }
            else
            {
                clienteModel.CalcularValor(_context);
            }

            return clienteModel;
        }

        // GET: Cliente/Create

        public IActionResult Create()
        {
            var agora = (DateTime.Now).ToString("yyyy-MM-ddTHH:mm:ss");
            ViewBag.dataAtual = agora;
            return View();
        }

        // POST: Cliente/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public bool Create(string pPlaca)
        {
            try
            {
                var cliente = new ClienteModel(pPlaca);
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public bool MarcarSaida(string pPlaca)
        {
            try
            {
                var cliente = _context.Clientes.Where(c => c.Placa == pPlaca).FirstOrDefault();
                cliente.DataSaida = DateTime.Now;
                cliente.CalcularValor(_context);
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // GET: Cliente/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clienteModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clienteModel == null)
            {
                return NotFound();
            }

            return View(clienteModel);
        }

        // POST: Cliente/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clienteModel = await _context.Clientes.FindAsync(id);
            _context.Clientes.Remove(clienteModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteModelExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
