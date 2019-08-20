using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestPromart.Models;

namespace TestPromart.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenServiciosController : ControllerBase
    {
        private readonly OrdenServicioContext _context;

        public OrdenServiciosController(OrdenServicioContext context)
        {
            _context = context;
        }

        // GET: api/OrdenServicios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdenServicio>>> GetOrdenServicios()
        {
            return await _context.OrdenServicios.ToListAsync();
        }

        // GET: api/OrdenServicios/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrdenServicio>> GetOrdenServicio(int id)
        {
            var ordenServicio = await _context.OrdenServicios.FindAsync(id);

            if (ordenServicio == null)
            {
                return NotFound();
            }

            return ordenServicio;
        }

        // PUT: api/OrdenServicios/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrdenServicio(int id, OrdenServicio ordenServicio)
        {
            if (id != ordenServicio.NIdSo)
            {
                return BadRequest();
            }

            _context.Entry(ordenServicio).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrdenServicioExists(id))
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

        // POST: api/OrdenServicios
        [HttpPost]
        public async Task<ActionResult<OrdenServicio>> PostOrdenServicio(OrdenServicio ordenServicio)
        {
            _context.OrdenServicios.Add(ordenServicio);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrdenServicio", new { id = ordenServicio.NIdSo }, ordenServicio);
        }

        // DELETE: api/OrdenServicios/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<OrdenServicio>> DeleteOrdenServicio(int id)
        {
            var ordenServicio = await _context.OrdenServicios.FindAsync(id);
            if (ordenServicio == null)
            {
                return NotFound();
            }

            _context.OrdenServicios.Remove(ordenServicio);
            await _context.SaveChangesAsync();

            return ordenServicio;
        }

        private bool OrdenServicioExists(int id)
        {
            return _context.OrdenServicios.Any(e => e.NIdSo == id);
        }
    }
}
