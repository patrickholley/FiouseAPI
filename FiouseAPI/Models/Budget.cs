using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiouseAPI.Models
{
    public class Budget
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public float Balance { get; set; }

        public byte LengthTypeId { get; set; }

        public LengthType LengthType { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
