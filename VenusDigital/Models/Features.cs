﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenusDigital.Models
{
    public class Features
    {
        [Key]
        public int FeatureId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Feature Title")]
        public string FeatureTitle { get; set; }
        [Required]
        [MaxLength(250)]
        [Display(Name = "Feature Value")]
        public string FeatureValue { get; set; }

        //Nav
        [ForeignKey("ProductId")]
        public Products Products { get; set; }
    }
}
