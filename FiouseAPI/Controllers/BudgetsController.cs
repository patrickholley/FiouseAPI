using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiouseAPI.Data;
using FiouseAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FiouseAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BudgetsController : ControllerBase
    {
        private readonly FiouseContext _context;

        public BudgetsController(FiouseContext context) {
            _context = context;

            if (_context.Budgets.Count() == 0) {
                _context.Budgets.Add(new Budget { Name = "UnemployedBudget", Balance = 125, LengthTypeId = 1 });
                _context.Budgets.Add(new Budget { Name = "EmployedBudget", Balance = 800, LengthTypeId = 4 });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<Budget>> Get() {
            return _context.Budgets.ToList();
        }

        [HttpGet("{id}")]
        public Budget Get(Guid id) {
            return _context.Budgets.Where(b => b.Id == id).Single();
        }

        // POST: api/Budgets
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Budgets/5
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
