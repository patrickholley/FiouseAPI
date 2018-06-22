using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FiouseAPI.Data;
using FiouseAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FiouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LengthTypesController : ControllerBase
    {
        private readonly FiouseContext _context;

        public LengthTypesController(FiouseContext context) {
            _context = context;

            if (_context.LengthTypes.Count() == 0) {
                _context.LengthTypes.Add(new LengthType { Name = "Weekly" });
                _context.LengthTypes.Add(new LengthType { Name = "Biweekly" });
                _context.LengthTypes.Add(new LengthType { Name = "Semimonthly" });
                _context.LengthTypes.Add(new LengthType { Name = "Monthly" });
                _context.LengthTypes.Add(new LengthType { Name = "Quarterly" });
                _context.LengthTypes.Add(new LengthType { Name = "Semiannually" });
                _context.LengthTypes.Add(new LengthType { Name = "Annually" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<LengthType>> Get()
        {
            return _context.LengthTypes.ToList();
        }

        [HttpGet("{id}")]
        public LengthType Get(int id)
        {
            return _context.LengthTypes.Where(l => l.Id == id).Single();
        }
    }
}
