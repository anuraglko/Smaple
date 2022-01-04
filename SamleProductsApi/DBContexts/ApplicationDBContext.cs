﻿using Microsoft.EntityFrameworkCore;
using SamleProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamleProductsApi.DBContexts
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
