using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Models;

namespace apiCatedra1.Src.Data
{
     public class DataSeeder
    {
        
        public static void Iniialize(IServiceProvider serviceProvider){
            using (var scope = serviceProvider.CreateScope()){
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<ApplicationDBContext>();

                if(!context.Categories.Any()){
                    context.Categories.AddRange(
                        new Category {Name = "poleras"},
                        new Category {Name = "sombreros"},
                        new Category {Name = "pantalones"}
                    );
                }
                context.SaveChanges();

                if(!context.Products.Any())
                {
                    var product = new Product {  
                        Name = "Polera Pique Azul",
                        categoryId = 1,
                        stock = 1000
                    };
                    context.Products.Add(product);
                }
                context.SaveChanges();
            }
            
        }
    }
}