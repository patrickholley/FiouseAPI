using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FiouseAPI.Models
{
    public class Expense
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public float Amount { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
