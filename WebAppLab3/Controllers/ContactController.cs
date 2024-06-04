using Microsoft.AspNetCore.Mvc;
using WebAppLab3.Data;
using WebAppLab3.Models;
using System;
using System.Linq;

namespace WebAppLab3.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _dbContext;

        public ContactController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Messages()
        {
            var messages = _dbContext.ContactUsEntries.ToList();
            return View(messages);
        }

        [HttpPost]
        public IActionResult SubmitForm([FromBody] ContactUsEntry model)
        {
            if (ModelState.IsValid)
            {
                model.Id = _dbContext.ContactUsEntries.Max(entry => (int)entry.Id) + 1;
                model.Timestamp = DateTime.Now;
                _dbContext.ContactUsEntries.Add(model);
                _dbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}