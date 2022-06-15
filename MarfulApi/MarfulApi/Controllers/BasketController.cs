using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BasketController : ControllerBase
    {
        private readonly IBasket db;
        public BasketController(IBasket _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetBasket()
        {
            IQueryable<Basket> data = db.GetBaskets;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetBasket(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddBasket([FromBody] Basket basket)
        {
            if (basket == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(basket);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Basket basket)
        {
            if (basket == null || basket.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(basket);
                return Ok();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
