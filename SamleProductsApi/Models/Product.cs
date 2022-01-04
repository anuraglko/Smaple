using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace SamleProductsApi.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public String ProductName { get; set; }

        public double ProductPrice { get; set; }

        public string ProductCategory { get; set; }



    }
}
