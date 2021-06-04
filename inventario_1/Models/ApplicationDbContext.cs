using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace inventario_1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            new ApplicationDbContext(Properties.Settings.Default.Connection);
        }

        public ApplicationDbContext(String connectionString) : base(connectionString) { }

        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
     }
}