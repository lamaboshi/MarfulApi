using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContent db;
        public ContentController(IContent _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetContents()
        {
            IQueryable<Content> data = db.GetContents;
            return Ok(data);
        }
    }
}
