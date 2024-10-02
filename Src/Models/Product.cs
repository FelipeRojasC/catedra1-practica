using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace apiCatedra1.Src.Models
{
    public class Product
    {
        public int Id {get; set;}
        
        
        public string Name {get; set;}
        public int stock {get; set;}

        //Relaciones

        public int IdType {get;set;}
        public Type Type {get;set;}
    }
}