using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetBtyId(int? id);
        Task<Category> Update(Category category);
        Task<Category> Remove(Category category);
        Task<Category> Create(Category category);
    }
}
