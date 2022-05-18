using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductyAsync();
        Task<Product> GetBtyIdAsync(int? id);

        Task<Product> GetProductCateboryAsync(int? id);

        Task<Product> UpdateAsync(Product category);
        Task<Product> RemoveAsync(Product category);
        Task<Product> CreateAsync(Product category);

    }
}
