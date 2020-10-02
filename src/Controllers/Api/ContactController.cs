using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using src.Data;
using src.Models;
using src.Services;

namespace src.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Contact")]  
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IDotnetdesk _dotnetdesk;

        private readonly IEmailSender _emailSender;

        public ContactController(ApplicationDbContext context,
            IDotnetdesk dotnetdesk,

            IEmailSender emailSender)
        {
            _context = context;
            _dotnetdesk = dotnetdesk;
            _emailSender = emailSender;
        }

        // GET: api/Contact
        [HttpGet("{customerId}")]
        public IActionResult GetContact([FromRoute]Guid customerId)
        {
            return Json(new { data = _context.Contact.Where(x => x.customerId.Equals(customerId)).ToList() });
        }

        // POST: api/Contact
        [HttpPost]
        public async Task<IActionResult> PostContact([FromBody] Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {

                if (contact.contactId == Guid.Empty)
                {


                    contact.contactId = Guid.NewGuid();
                    _context.Contact.Add(contact);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Add new data success." });



                }
                else
                {
                    _context.Update(contact);

                    await _context.SaveChangesAsync();

                    return Json(new { success = true, message = "Edit data success." });
                }
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }

        }

        // DELETE: api/Contact/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var contact = await _context.Contact.SingleOrDefaultAsync(m => m.contactId == id);
                if (contact == null)
                {
                    return NotFound();
                }

                _context.Contact.Remove(contact);
                await _context.SaveChangesAsync();


                return Json(new { success = true, message = "Delete success." });
            }
            catch (Exception ex)
            {

                return Json(new { success = false, message = ex.Message });
            }


        }

        private bool ContactExists(Guid id)
        {
            return _context.Contact.Any(e => e.contactId == id);
        }
    }
}