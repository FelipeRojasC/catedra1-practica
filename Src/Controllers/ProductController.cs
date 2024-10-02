using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.DTOs;
using apiCatedra1.Src.Models;
using apiCatedra1.Src.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiCatedra1.Src.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {

    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;
    

    public ProductController(IProductRepository productRepository,ICategoryRepository categoryRepository){
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
    }
    [HttpPost("")]
    public async Task<IResult> CreateProduct(ProductDTO productDTO){
        
        try{
            if(await _productRepository.VerifyCodeProduct(productDTO.stock)){ //puse stock por que no tengo code
                return TypedResults.Conflict();
            }
            if(!_categoryRepository.VerifyCategory(productDTO.CategoryId).Result){
                return TypedResults.BadRequest("No existe ese categoria.");
            }
            var product = new Product {  
                        Name = productDTO.Name,
                        categoryId = productDTO.CategoryId,
                        stock = productDTO.stock
                    };
            await _productRepository.AddProduct(product);
            return TypedResults.Ok();
        }
        catch(Exception ex){


            return TypedResults.BadRequest("Esta todo mal.");
        }
    }
    
    [HttpGet("")]
    public async Task<IActionResult> GetProducts (){
         // Llamar al repositorio para obtener los productos
        var products = await _productRepository.GetProducts();
        
        // Retornar los productos como respuesta HTTP 200 OK
        return Ok(products);
    }
    }
}