using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("v1/products")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Product>>> Get([FromServices] DataContext ctx)
        {
            var products = await ctx.Products
                                    .AsNoTracking()
                                    .Include(x=> x.Category).ToListAsync();
            return products;
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Product>> GetById(
                [FromServices] DataContext ctx,
                int id)
        {
            var product = await ctx.Products
                                    .AsNoTracking()
                                    .Include(x=> x.Category)
                                    .Where(x=> x.Id == id).FirstOrDefaultAsync();
            return product;
        }

        [HttpGet]
        [Route("categories/{id:int}")]
        public async Task<ActionResult<List<Product>>> GetByCategory(
            [FromServices] DataContext ctx,
            int id)
        {
            var products = await ctx.Products
                      .AsNoTracking()
                      .Include(x=> x.Category)
                      .Where(x => x.CategoryId == id)
                      .ToListAsync();
                      
            return products;

        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Product>> Post(
            [FromServices] DataContext ctx,
            [FromBody] Product model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            ctx.Products.Add(model);
            await ctx.SaveChangesAsync(); // persistindo
            return Ok(model);            
        }
    }

}