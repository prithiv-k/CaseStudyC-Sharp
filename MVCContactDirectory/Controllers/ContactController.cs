using Microsoft.AspNetCore.Mvc;
using MVCContactDirectory.Model;
using System.Collections.Generic;
using System.Linq;

namespace MVCContactDirectory.Controllers
{
    public class ContactController : Controller
    {
        static List<ContactInfo> contacts = new List<ContactInfo>();

        public IActionResult ShowContacts()
        {
            return View(contacts);
        }

        public IActionResult GetContactById(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.ContactId == id);
            if (contact == null)
                return NotFound();
            return View(contact);
        }

        [HttpGet]
        [Route("AddContact", Name = "AddContact")]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        [Route("AddContact")]
        public IActionResult AddContact(ContactInfo contactInfo)
        {
            contactInfo.ContactId = contacts.Count > 0 ? contacts.Max(c => c.ContactId) + 1 : 1;
            contacts.Add(contactInfo);
            return RedirectToAction("ShowContacts");
        }
    }
}
