using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProyectoBibliotecaAPI.Data;
using ProyectoBibliotecaAPI.Models;

namespace ProyectoBibliotecaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BibliotecariosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BibliotecariosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Bibliotecarios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bibliotecario>>> GetBibliotecario()
        {
            return await _context.Bibliotecario.ToListAsync();
        }

        // GET: api/Bibliotecarios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Bibliotecario>> GetBibliotecario(int id)
        {
            var bibliotecario = await _context.Bibliotecario.FindAsync(id);

            if (bibliotecario == null)
            {
                return NotFound();
            }

            return bibliotecario;
        }

        // PUT: api/Bibliotecarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBibliotecario(int id, Bibliotecario bibliotecario)
        {
            if (id != bibliotecario.ID)
            {
                return BadRequest();
            }

            _context.Entry(bibliotecario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BibliotecarioExists(id))
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

        // POST: api/Bibliotecarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Bibliotecario>> PostBibliotecario(Bibliotecario bibliotecario)
        {
            _context.Bibliotecario.Add(bibliotecario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBibliotecario", new { id = bibliotecario.ID }, bibliotecario);
        }

        // DELETE: api/Bibliotecarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBibliotecario(int id)
        {
            var bibliotecario = await _context.Bibliotecario.FindAsync(id);
            if (bibliotecario == null)
            {
                return NotFound();
            }

            _context.Bibliotecario.Remove(bibliotecario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BibliotecarioExists(int id)
        {
            return _context.Bibliotecario.Any(e => e.ID == id);
        }
    }
}
