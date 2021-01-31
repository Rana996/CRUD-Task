using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webb.Models
{
    public class ProductsContext:DbContext
    {
         public ProductsContext(DbContextOptions<ProductsContext> options):base(options)
        {
           
        }

        public DbSet<Products> Production { get; set; }
    }
}
