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
    public class RecomendacionsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RecomendacionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Recomendacions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Recomendacion>>> GetRecomendacion()
        {
            return await _context.Recomendacion.ToListAsync();
        }

        // GET: api/Recomendacions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Recomendacion>> GetRecomendacion(int id)
        {
            var recomendacion = await _context.Recomendacion.FindAsync(id);

            if (recomendacion == null)
            {
                return NotFound();
            }

            return recomendacion;
        }

        // PUT: api/Recomendacions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecomendacion(int id, Recomendacion recomendacion)
        {
            if (id != recomendacion.ID)
            {
                return BadRequest();
            }

            _context.Entry(recomendacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecomendacionExists(id))
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

        // POST: api/Recomendacions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Recomendacion>> PostRecomendacion(Recomendacion recomendacion)
        {
            _context.Recomendacion.Add(recomendacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecomendacion", new { id = recomendacion.ID }, recomendacion);
        }

        // DELETE: api/Recomendacions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecomendacion(int id)
        {
            var recomendacion = await _context.Recomendacion.FindAsync(id);
            if (recomendacion == null)
            {
                return NotFound();
            }

            _context.Recomendacion.Remove(recomendacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecomendacionExists(int id)
        {
            return _context.Recomendacion.Any(e => e.ID == id);
        }
    }
}
