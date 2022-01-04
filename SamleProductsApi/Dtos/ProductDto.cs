using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamleProductsApi.Models.Dtos
{
    public class ProductDto
    {
        
        public int ProductId { get; set; }
        
        public String ProductName { get; set; }

        public double ProductPrice { get; set; }

        public string ProductCategory { get; set; }
    }
}
