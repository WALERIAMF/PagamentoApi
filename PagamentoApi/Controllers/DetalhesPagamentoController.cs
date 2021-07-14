using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagamentoData.Context;
using PagamentoData.Repository;
using PagamentoDomain.IRepository;
using PagamentoDomain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PagamentoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetalhesPagamentoController : ControllerBase
    {
        private readonly Context _context;

        public DetalhesPagamentoController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DetalhesPagamentoModel>>> GetDetalhesPagamento()
        {
            return await _context.DetalhesPagamento.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DetalhesPagamentoModel>> GetDetalhesPagamento(int id)
        {
            var detalhesPagamento = await _context.DetalhesPagamento.FindAsync(id);
            if(detalhesPagamento == null)
            {
                return NotFound();
            }
            return detalhesPagamento;
        }

        [HttpPut("(id")]
        public async Task<IActionResult> PutDetalhesPagamento(string id, DetalhesPagamentoModel detalhesPagamento)
        {
            if (id != detalhesPagamento.Id)
            {
                return BadRequest();
            }
            _context.Entry(detalhesPagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DetalhesPagamentoExist(id))
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
       
        [HttpPost]
        public async Task<ActionResult<DetalhesPagamentoModel>> PostDetalhesPagamento(DetalhesPagamentoModel detalhesPagamento)
        {
            _context.DetalhesPagamento.Add(detalhesPagamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDetalhesPagamento", new {id = detalhesPagamento.Id}, detalhesPagamento);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDetalhesPagamento(string id)
        {
            var detalhesPagamento = await _context.DetalhesPagamento.FindAsync(id);
            if(detalhesPagamento == null)
            {
                return NotFound();
            }

            _context.DetalhesPagamento.Remove(detalhesPagamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DetalhesPagamentoExist(string id)
        {
            return _context.DetalhesPagamento.Any(e => e.Id == id);
        }
    }
}
