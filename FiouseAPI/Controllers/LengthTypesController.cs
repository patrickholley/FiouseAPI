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

        [HttpGet]
        public ActionResult<List<LengthType>> Get()
        {
            return _context.LengthTypes.ToList();
        }

        [HttpGet("{id}")]
        public LengthType Get(int id)
        {
            return _context.LengthTypes.Where(x => x.Id == id).Single();
        }
    }
}
