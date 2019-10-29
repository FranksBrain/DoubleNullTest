using System;
using Microsoft.AspNetCore.Mvc;

namespace DoubleNullTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        // POST: api/Project
        [HttpPost]
        public void Post([FromBody] Project project)
        {
            Console.WriteLine(project);
        }
    }
}