using Microsoft.AspNetCore.Mvc;
using LoginPageDemo.Data;
using DevExtreme.AspNet.Data;
using Microsoft.EntityFrameworkCore;
using LoginPageDemo.Models;

namespace LoginPageDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GridController : ControllerBase
    {
        private readonly AppDbContext _db;
        public GridController(AppDbContext db) => _db = db;

        [HttpGet("all")]
        public async Task<IEnumerable<GridItem>> GetAll() => await _db.GridItems.ToListAsync();

        [HttpPost("load")]
        public IActionResult Load([FromBody] DataSourceLoadOptionsBase loadOptions)
        {
            var query = _db.GridItems.AsQueryable();
            var result = DataSourceLoader.Load(query, loadOptions);
            return Ok(result);
        }
    }
}
