using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Data;
namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearch db;
        public SearchController(ISearch _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("Search")]
        public IActionResult Search(string search)
        {
            if(search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.Search(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("SearchInfulonser")]
        public IActionResult SearchInfulonser([FromQuery] string search)
        {
            if(search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.SearchInfulonser(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("SearchCompany")]
        public IActionResult SearchCompany([FromQuery] string search)
        {
            if (search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.SearchCompany(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("SearchBrand")]
        public IActionResult SearchBrand([FromQuery] string search)
        {
            if (search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.SearchBrand(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("SearchProduct")]
        public IActionResult SearchProduct([FromQuery] string search)
        {
            if (search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.SearchProduct(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("SearchContent")]
        public IActionResult SearchContent([FromQuery] string search)
        {
            if (search == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.SearchContent(search);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
    }
}
