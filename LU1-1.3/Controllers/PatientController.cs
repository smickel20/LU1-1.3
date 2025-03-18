using LU1_1._3.Models; // Ensure your models are properly referenced
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LU1_1._3.Controllers
{
    [ApiController]
    [Authorize]
    [Route("/[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;

        public PatientController(ILogger<PatientController> logger)
        {
            _logger = logger;
        }

        // GET: /Child/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetById(string id)
        {
            // Empty method
            return Ok(); // Or whatever is appropriate (null/empty response)
        }

        // POST: /Child
        [HttpPost]
        public async Task<ActionResult<Patient>> Create([FromBody] Patient patient)
        {
            // Empty method
            return Ok(); // Or whatever is appropriate (null/empty response)
        }

        // PUT: /Child/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, [FromBody] Patient patient)
        {
            // Empty method
            return NoContent(); // Or whatever is appropriate (null/empty response)
        }

        // DELETE: /Child/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            // Empty method
            return Ok(); // Or whatever is appropriate (null/empty response)
        }
    }
}
