using Microsoft.AspNetCore.Mvc;
using SamleProductsApi.DAL;
using SamleProductsApi.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SampleProductAPI.Models.Dto;

namespace SampleProductAPI.Controllers
{
    [Route("api/products")]
    public class ProductAPIController : ControllerBase
    {
       
        private IProduct product;
        public ResponseDto Response { get; set; }
     
        public ProductAPIController(IProduct prd)
        {
            product = prd;
            Response = new ResponseDto();
        }
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            try
            {
                IEnumerable<ProductDto> productDtos = await product.GetProducts();
                Response.Result = productDtos;
                
            }
            catch(Exception ex)
            {
                Response.IsSuccess = false;
                Response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return Response;
        }

        [HttpGet]
        [Route("{id}")]
                public async Task<object> Get(int id)
        {
            try
            {
                ProductDto productDto = await product.GetProduct(id);
                Response.Result = productDto;
              return  Ok(Response);
            }
            catch (Exception ex)
            {
                Response.IsSuccess = false;
                Response.ErrorMessages
                     = new List<string>() { ex.ToString() };
            }
            return Response;
        }


    }
}
