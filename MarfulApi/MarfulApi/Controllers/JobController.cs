using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IJob db;
        public JobController(IJob _db)
        {
            db = _db;
        }
        [HttpGet("{idbrand}")]
        [ActionName("GetJobsCompany")]
        public IActionResult GetJobsCompany(int idbrand)
        {
           var data = db.GetJobsCompany(idbrand);
            return Ok(data);
        }
        [HttpGet("{idinfo}")]
        public IActionResult Get(int idinfo)
        {
            var data = db.GetJobsInfo(idinfo);
            return Ok(data);

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
