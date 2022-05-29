using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJob db;
        public JobController(IJob _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetJob()
        {
            IQueryable<Job> data = db.GetJobs;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetJob(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddJob([FromBody] Job job)
        {
            if (job == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(job);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Job job)
        {
            if (job == null || job.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(job);
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
