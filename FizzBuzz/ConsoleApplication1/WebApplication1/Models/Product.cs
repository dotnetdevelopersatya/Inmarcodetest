using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace WebApplication1.Models
{
    //  Create   a   class   named   "Product"   with    

    //var varInt = new ProductViewModel("Toothpaste", 10.00, "Toothpaste contains salt");

    public class ProductViewModel
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}