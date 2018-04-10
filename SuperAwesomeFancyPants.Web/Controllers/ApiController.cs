using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SuperAwesomeFancyPants.Web.Controllers
{
    public class ApiController : Controller
    {
        [Route("api/data")]
        public IActionResult GetSomeData()
        {
            return Ok(new SomeObject
            {
                Name = "hellao",
                Age = 383,
            });
        }
    }

    public class SomeObject
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
