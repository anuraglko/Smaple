using Microsoft.EntityFrameworkCore;
using SamleProductsApi.DBContexts;
using SamleProductsApi.Models;
using SamleProductsApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace SamleProductsApi.DAL
{
    public class ProductDal : IProduct
    {
        public readonly ApplicationDBContext dbContext;
        IMapper mapper;
        public ProductDal(ApplicationDBContext db,IMapper mp)
        {
            dbContext = db;
            mapper = mp;
        }
        public async Task<ProductDto> GetProduct(int id)
        {
            Product pd = await dbContext.Products.Where(pd => pd.ProductId == id).FirstOrDefaultAsync();
            return mapper.Map<ProductDto>(pd);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List< Product> prd= await dbContext.Products.ToListAsync();

            return mapper.Map<List<ProductDto>>(prd); 
           // return pro;

        }

    }
}
