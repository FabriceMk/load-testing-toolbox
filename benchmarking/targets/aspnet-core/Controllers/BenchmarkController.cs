﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreTarget.Controllers
{
    [ApiController]
    [Route("/benchmark")]
    public class BenchmarkController : ControllerBase
    {
        /// <summary>
        /// Simple HTTP benchmark endpoint.
        /// Returns a string with current UTC Time.
        /// </summary>
        /// <returns>An HTTP result.</returns>
        /// <response code="200">Returns a simple string and the current UTC time.</response>
        [Route("simple-http")]
        [HttpGet]
        public IActionResult SimpleHttp()
        {
            var message = $"Hitting ASP.NET Core : {DateTime.UtcNow}";
            return Ok(message);
        }
    }
}
