﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

namespace VenusDigital.Models
{
    public class OrderDetails
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Count { get; set; }

        public string? Color { get; set; }

        //Nav
        [ForeignKey("ProductId")]
        public Products Product { get; set; }
        public Order Order { get; set; }
    }
}
