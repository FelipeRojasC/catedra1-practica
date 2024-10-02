using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace apiCatedra1.Src.Models
{
    public class Product
    {
        [Key]
        public int Id {get; set;}
        

        public string Name {get; set;}
        public int stock {get; set;}

        //Relaciones

        public int categoryId {get;set;}
        public Category Category {get;set;}
    }
}