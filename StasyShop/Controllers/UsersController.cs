using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
namespace StasyShop.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    { 
        List<User> users = new List<User>();
        // GET api/users
        [HttpGet]
        public List<User> Get()
        {
            
            User shaila = new User("Shaila");
            User jacob = new User("Jacob");
            User peter = new User("Peter");

            this.users.Add(shaila);
            this.users.Add(jacob);
            this.users.Add(peter);

            Console.WriteLine("work");

            return this.users;
        }

        // POST api/users
        [HttpPost]
        public StatusCodeResult Post()
        {
            //Console.WriteLine(" name : " + name);
            //User newPerson = new User(" ops");
            //this.users.Add(newPerson);
            Console.WriteLine("work in POST request");

            return StatusCode(200);
        }
    }
}