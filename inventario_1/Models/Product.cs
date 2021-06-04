using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventario_1.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Category Category { get; set; }
    }
}