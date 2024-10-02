using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Models;

namespace apiCatedra1.Src.DTOs
{
    public class ProductDTO
    {
        public string Name {get; set;}
        public int stock {get; set;}
        public int CategoryId {get;set;}
    }
}