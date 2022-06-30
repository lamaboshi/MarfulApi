﻿using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser db;
        public UserController(IUser _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetUser")]
        public IActionResult GetUser()
        {
            IQueryable<User> data = db.GetUsers;
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var data = db.GetUser(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                bool data = db.IsExisting(user.Email);
                if (data == false)
                {
                    db.Save(user);
                    return Ok();
                }
                else return NotFound();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(user);
                return Ok();
            }
        }
        [HttpPut]
        public IActionResult Password([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.ChangePassword(user);
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
