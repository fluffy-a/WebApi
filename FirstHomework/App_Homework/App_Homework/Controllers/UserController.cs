using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App_Homework.Models;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace App_Homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/user
        [HttpGet]
        public ActionResult<List<User>> GetAllUsers()
        {
            var listOfAllUsers= StaticDb.Users.ToList();
            if (listOfAllUsers.Count < 3)
                return StatusCode(StatusCodes.Status204NoContent);
            return StatusCode(StatusCodes.Status200OK, listOfAllUsers);
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            var user= StaticDb.Users.SingleOrDefault(x => x.Id == id);
            if (user == null)
                return StatusCode(StatusCodes.Status404NotFound, new User());
            return StatusCode(StatusCodes.Status200OK, user);
        }



        // DELETE api/user/5
        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var user = StaticDb.Users.FirstOrDefault(x => x.Id == id);
            return StaticDb.Users.Remove(user) ? StatusCode(StatusCodes.Status200OK,value:"Deleted") : StatusCode(StatusCodes.Status400BadRequest,value:"Not deleted");

        }


        // POST api/user
        [HttpPost]
        public ActionResult<string> CreateUser([FromBody] User user)
        {
            var checkingIfUserIsAdded = StaticDb.Users.SingleOrDefault(x => x.Id == user.Id);
            if (checkingIfUserIsAdded != null)
            return StatusCode(StatusCodes.Status400BadRequest, value: "The user already exist");
            
            StaticDb.Users.Add(user);

            return StatusCode(StatusCodes.Status201Created, value:"The user is added");



        }

    }
 }
