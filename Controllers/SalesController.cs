using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalesAPI.Models;

namespace SalesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly SalesAPIContext _context;

        public SalesController(SalesAPIContext context)
        {
            _context = context;
        }

        // GET: api/Sales
        [HttpGet]
        public IEnumerable<SalesItem> GetSalesItem()
        {
            return _context.SalesItem;
        }

        // GET: api/Sales/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSalesItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salesItem = await _context.SalesItem.FindAsync(id);

            if (salesItem == null)
            {
                return NotFound();
            }

            return Ok(salesItem);
        }

        // PUT: api/Sales/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSalesItem([FromRoute] int id, [FromBody] SalesItem salesItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salesItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(salesItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalesItemExists(id))
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

        // POST: api/Sales
        [HttpPost]
        public async Task<IActionResult> PostSalesItem([FromBody] SalesItem salesItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.SalesItem.Add(salesItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalesItem", new { id = salesItem.Id }, salesItem);
        }

        // DELETE: api/Sales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSalesItem([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var salesItem = await _context.SalesItem.FindAsync(id);
            if (salesItem == null)
            {
                return NotFound();
            }

            _context.SalesItem.Remove(salesItem);
            await _context.SaveChangesAsync();

            return Ok(salesItem);
        }

        private bool SalesItemExists(int id)
        {
            return _context.SalesItem.Any(e => e.Id == id);
        }

        // GET: api/Sales/Tags
        [Route("tags")]
        [HttpGet]
        public async Task<List<string>> GetTags()
        {
            var sales = (from s in _context.SalesItem
                         select s.Tags).Distinct();

            var returned = await sales.ToListAsync();

            return returned;
        }
    }
}