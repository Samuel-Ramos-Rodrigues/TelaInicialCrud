using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TelaInicialCrud.Areas.Identity.Data;
using TelaInicialCrud.Models;

namespace TelaInicialCrud.Controllers
{
    [Authorize]
    public class ProjetoController : Controller
    {
        private readonly TelaInicialCrudContext _context;

        public ProjetoController(TelaInicialCrudContext context)
        {
            _context = context;
        }

        // GET: Projeto
        public async Task<IActionResult> Index()
        {
            return View(await _context.Projeto.ToListAsync());
        }

        // GET: Projeto/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projeto
                .FirstOrDefaultAsync(m => m.IdProjeto == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return View(projeto);
        }

        // GET: Projeto/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Projeto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProjeto,NomeProjeto,Descricao,valor,DataInicio,DataFinal,QuantPessoas")] Projeto projeto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projeto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projeto);
        }

        // GET: Projeto/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projeto.FindAsync(id);
            if (projeto == null)
            {
                return NotFound();
            }
            return View(projeto);
        }

        // POST: Projeto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProjeto,NomeProjeto,Descricao,valor,DataInicio,DataFinal,QuantPessoas")] Projeto projeto)
        {
            if (id != projeto.IdProjeto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projeto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjetoExists(projeto.IdProjeto))
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
            return View(projeto);
        }

        // GET: Projeto/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projeto = await _context.Projeto
                .FirstOrDefaultAsync(m => m.IdProjeto == id);
            if (projeto == null)
            {
                return NotFound();
            }

            return View(projeto);
        }

        // POST: Projeto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var projeto = await _context.Projeto.FindAsync(id);
            if (projeto != null)
            {
                _context.Projeto.Remove(projeto);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjetoExists(int id)
        {
            return _context.Projeto.Any(e => e.IdProjeto == id);
        }
    }
}
