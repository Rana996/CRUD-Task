using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webb.Models
{
    public class Products
    {
        [Key]
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public byte[] ProductImage { get; set; }
    }
}
