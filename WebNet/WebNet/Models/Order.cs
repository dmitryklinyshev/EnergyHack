using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebNet.Models
{
    public class Order
    {
        
        [Required]
        public int Id { get; set; }
        [Required]
        public string Task { get; set; }
        [Required]
        public DateTime Date { get; set; }
    }
}
