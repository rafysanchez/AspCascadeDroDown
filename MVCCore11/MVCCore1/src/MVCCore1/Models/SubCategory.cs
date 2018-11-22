﻿using System.ComponentModel.DataAnnotations;

namespace MVCCore1.Models
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }
        public string SubCategoryName { get; set; }
    }
}
