using Api.Restaurante.Context;
using Api.Restaurante.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratosController : ControllerBase
    {
        private readonly RestauranteContext _context;

        public PratosController(RestauranteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Prato>>> Get()
        {
            var pratos = await _context.Pratos.ToListAsync();
            if (pratos is null)
            {
                return NotFound("Prato Não localizado");
            }
            return Ok(pratos);  
        }

        [HttpGet("{id}", Name = "ObterPrato")]
        public async Task <ActionResult<Prato>> Get(int id)
        {
            var prato = await _context.Pratos.FirstOrDefaultAsync(p => p.PratoId == id);

            if (prato is null) 
            { 
                return NotFound();
            }
            return Ok(prato);
        }

        [HttpPost]
        public ActionResult Post(Prato prato)
        {
            if (prato is null)
            {
                return BadRequest();
            }

            _context.Pratos.Add(prato);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPrato", 
                new { id = prato.PratoId }, prato);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Prato prato)
        {
            if (id != prato.PratoId)
            {
                return BadRequest();    
            }

            _context.Entry(prato).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(prato);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var prato = _context.Pratos.FirstOrDefault(p => p.PratoId == id);   

            if(prato is null)
            {
                return NotFound("Prato não localizado!");
            }
            _context.Pratos.Remove(prato);
            _context.SaveChanges();

            return Ok(prato);
        }
    }
}
