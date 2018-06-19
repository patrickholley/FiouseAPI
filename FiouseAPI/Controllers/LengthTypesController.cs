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
    public class LengthTypesController : ControllerBase
    {
        private readonly FiouseContext _context;

        public LengthTypesController(FiouseContext context) {
            _context = context;
        }

        // GET: api/LengthType
        [HttpGet]
        public ActionResult<List<LengthType>> GetAll()
        {
            return _context.LengthTypes.ToList();
        }

        // GET: api/LengthType/5
        [HttpGet("{id}")]
        public LengthType Get(int id)
        {
            return _context.LengthTypes.Where(x => x.Id == id).Single();
        }

        // POST: api/LengthType
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/LengthType/5
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
