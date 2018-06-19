using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiouseAPI.Models
{
    public class Budget
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public byte LengthTypeId { get; set; }
        public LengthType LengthType { get; set; }
    }
}
