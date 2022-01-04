using System;
using Xunit;
using SampleProductAPI.Controllers;

namespace SapleTest
{
    public class UnitTest1
    {
        [Fact]
        public void GetProduct()
        {
            SamleProductsApi.DAL.IProduct pd = new SamleProductsApi.DAL.ProductDal(new SamleProductsApi.DBContexts.ApplicationDBContext(), new AutoMapper.Mapper());

            var pro = new ProductAPIController(pd);

            pro

        }
    }
}
