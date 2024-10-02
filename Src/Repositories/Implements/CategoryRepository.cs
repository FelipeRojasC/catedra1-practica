using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Data;
using apiCatedra1.Src.Models;
using apiCatedra1.Src.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiCatedra1.Src.Repositories.Implements
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDBContext _context;

        public CategoryRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetCategory()
        {
            var productTypes = await _context.Categories.ToListAsync();
            return productTypes;
        }

        public async Task<bool> VerifyCategory(int id)
        {
            var productType = await _context.Categories.FindAsync(id);
            return productType != null;
        }
    }
}