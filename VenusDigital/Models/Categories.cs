﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VenusDigital.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(150)]
        public string CategoryName { get; set; }
        public Nullable<int> ParentId { get; set; }
        [MaxLength(150)]
        public string ParentCategoryBanner { get; set; }
        [MaxLength(150)]
        public string CategoryBanner { get; set; }

        //Nav
        [ForeignKey("CategoryId")]
        public Categories Category { get; set; }

        public List<SelectedCategory> SelectedCategory { get; set; }

    }
}
