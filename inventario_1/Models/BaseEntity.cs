using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace inventario_1.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
    }
}