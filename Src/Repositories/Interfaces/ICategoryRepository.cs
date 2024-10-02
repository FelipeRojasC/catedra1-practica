using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiCatedra1.Src.Models;

namespace apiCatedra1.Src.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategory();

        Task<bool> VerifyCategory(int id);
    }
}