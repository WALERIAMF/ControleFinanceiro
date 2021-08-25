using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleFinanceiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly Contexto _contexto;

        public CategoriaController(Contexto contexto)
        {
            _contexto = contexto;
        }
        // GET: api/<CategoriaController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaModel>>> GetCategorias()
        {
            return await _contexto.Categorias.ToListAsync();
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaModel>> GetCategoria(string id)
        {
            var categoria = await _contexto.Categorias.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            return categoria;
        }

        // POST api/<CategoriaController>
        [HttpPost]
        public async Task<ActionResult<CategoriaModel>> PostCategoria(CategoriaModel categoria)
        {
            _contexto.Categorias.Add(categoria);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = categoria.IdInterno }, categoria);
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoria(string id, CategoriaModel categoria)
        {
            if (id != (categoria.IdInterno))
            {
                return BadRequest();
            }
            _contexto.Entry(categoria).State = EntityState.Modified;

            try
            {
                await _contexto.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        private bool CategoriaExists(string id)
        {
            return _contexto.Categorias.Any(e => e.IdInterno == id);
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriaModel>> DeleteCategoria(string id)
        {
            var categoria = await _contexto.Categorias.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }
            _contexto.Categorias.Remove(categoria);
            await _contexto.SaveChangesAsync();

            return categoria;
        }
    }
}
