using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiouseAPI.Data;
using FiouseAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        private readonly FiouseContext _context;

        public ExpensesController(FiouseContext context) {
            _context = context;

            if (_context.Expenses.Count() == 0) {
                _context.Expenses.Add(new Expense { Date = DateTime.Today, Amount = 6.42F, Description = "Extra Most Bestest Pepporni Pizza" });
                _context.Expenses.Add(new Expense { Date = DateTime.Today.AddDays(-2), Amount = 6.42F, Description = "Extra Most Bestest Pepporni Pizza" });
                _context.Expenses.Add(new Expense { Date = DateTime.Today.AddDays(4), Amount = 6.42F, Description = "Extra Most Bestest Pepporni Pizza" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Expense>> Get() {
            return _context.Expenses.ToList();
        }

        [HttpGet("{id}")]
        public Expense Get(Guid id) {
            return _context.Expenses.Where(e => e.Id == id).Single();
        }

        // POST: api/Expenses
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
