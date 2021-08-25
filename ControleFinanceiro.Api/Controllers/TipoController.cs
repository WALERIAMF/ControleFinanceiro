using ControleFinanceiro.Data.Context;
using ControleFinanceiro.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ControleFinanceiro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoController : ControllerBase
    {
        private readonly Contexto _contexto;

        public TipoController(Contexto contexto)
        {
            _contexto = contexto;
        }


        // GET: api/<TipoController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoModel>>> GetTipo()
        {
            return await _contexto.Tipos.ToListAsync();
        }

        // GET api/<TipoController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TipoModel>> GetTipo(string id)
        {
            var tipo = await _contexto.Tipos.FindAsync(id);
            if(tipo == null)
            {
                return NotFound();
            }
            return tipo;
        }

        // POST api/<TipoController>
        [HttpPost]
        public async Task<ActionResult<TipoModel>> PostTipo(TipoModel tipo)
        {
            _contexto.Tipos.Add(tipo);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction("GetTipo", new { id = tipo.IdInterno }, tipo);
        }

        // PUT api/<TipoController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo(string id, TipoModel tipo)
        {
            if(id != tipo.IdInterno)
            {
                return BadRequest();
            }

            _contexto.Entry(tipo).State = EntityState.Modified;

            try
            {
                await _contexto.SaveChangesAsync();
            }

            catch (DbUpdateConcurrencyException)
            {
                if (!TipoExists(id))
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

        private bool TipoExists(string id)
        {
            return _contexto.Tipos.Any(e => e.IdInterno == id);
        }

        // DELETE api/<TipoController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TipoModel>> DeleteTipo(string id)
        {
            var tipo = await _contexto.Tipos.FindAsync(id);
            if(tipo == null)
            {
                return NotFound();
            }

            _contexto.Tipos.Remove(tipo);
            await _contexto.SaveChangesAsync();
            return tipo;
        }
    }
}
