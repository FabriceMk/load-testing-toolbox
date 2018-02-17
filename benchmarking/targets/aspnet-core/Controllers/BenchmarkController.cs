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
