using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace apiCatedra1.Src.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : Controller
    {
    [HttpPost("")]
    public IResult CreateProduct(ProductDTO productDTO){
        return TypedResults.Ok();
    }
    }
}