
using EcocysAPI.Data;
using EcocysAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecocys.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostContact([FromBody] ContactUs contact)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.ContactUs.Add(contact);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Form submitted successfully!", contact });
        }

        [HttpGet]
        public IActionResult GetContacts()
        {
            var contacts = _context.ContactUs.ToList();
            return Ok(contacts);
        }
    }
}
