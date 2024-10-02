using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiCatedra1.Src.Repositories.Interfaces
{
    public interface IProductRepository
    {
      Task<bool> AddProduct(Product product);  
      Task<bool> VerifyCodeProduct(int id);

      Task<List<Product>> GetProducts();
    }
}