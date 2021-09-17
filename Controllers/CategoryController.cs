using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    [ApiController]
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext ctx)
        {
            var categories = await ctx.Categories.AsNoTracking().ToListAsync();
            return categories;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Category>> Post(
            [FromServices] DataContext ctx,
            [FromBody] Category model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            
            ctx.Categories.Add(model);
            await ctx.SaveChangesAsync(); // persistindo
            return Ok(model);            
        }
    }

}