using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Models;
using Microsoft.EntityFrameworkCore;

namespace apiCatedra1.Src.Data
{
    public class ApplicationDBContext(DbContextOptions dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Product> Products {get; set;} = null;
        public DbSet<Category> Categories {get; set;} = null;
    }
}