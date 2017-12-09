using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTarget.Controllers
{
    [Route("[controller]")]
    public class BenchmarkController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "Hello world!";
        }
    }
}
