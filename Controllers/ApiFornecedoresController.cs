using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_Completo.Models;

namespace mvc_completo1.Controllers
{
    public class ApiFornecedoresController : ControllerBase
    {
        private readonly ContextoCms _context;

        public ApiFornecedoresController(ContextoCms context)
        {
            _context = context;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
            return StatusCode(200, await _context.Fornecedores.ToListAsync());
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.Fornecedores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return StatusCode(200, fornecedor);
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Nome,Telefone,CNPJ,Endereco")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return StatusCode(200, fornecedor);
        }

       
        [HttpPut]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Telefone,CNPJ,Endereco")] Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return StatusCode(200, fornecedor);
        }


        [HttpDelete, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fornecedor = await _context.Fornecedores.FindAsync(id);
            _context.Fornecedores.Remove(fornecedor);
            await _context.SaveChangesAsync();
            return StatusCode(204);
        }

        private bool FornecedorExists(int id)
        {
            return _context.Fornecedores.Any(e => e.Id == id);
        }
    }
}
