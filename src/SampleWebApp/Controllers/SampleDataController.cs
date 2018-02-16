using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ReactSpa.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet]
        public IActionResult GetHelloWorld()
        {
            return Json(new { message = "Hello, world!" });
        }
    }
}
