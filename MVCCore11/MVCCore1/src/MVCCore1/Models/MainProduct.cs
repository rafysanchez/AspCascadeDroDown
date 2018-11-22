﻿using System.ComponentModel.DataAnnotations;

namespace MVCCore1.Models
{
    public class MainProduct
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryID { get; set; }
    }
}
