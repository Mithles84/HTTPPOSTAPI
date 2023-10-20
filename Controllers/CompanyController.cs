using HTTPPOSTAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace HTTPPOSTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly APIContext context;

        public ValuesController(APIContext context)
        {
            this.context = context;
        }
        [HttpGet]

        public async Task<ActionResult<List<Company>>> GetData()
        {
            var data = await context.Companies.ToListAsync();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult CreateItem([FromBody] CompanyData data)
        {
            if (!ModelState.IsValid)
            {
                var validationErrors = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                return BadRequest(new
                {
                    data = 0,
                    validationMessages = validationErrors,
                    message = "Validation failed. Please check validation messages."
                });
            }

            // Implement the logic to save the data to the database (e.g., Entity Framework).

            return Ok(new
            {
                data = 1,
                validationMessages = new List<string>(),
                message = "All records Saved Successfully"
            });
        }

    }

    public class AcceptedResult<T>
    {
    }
}
