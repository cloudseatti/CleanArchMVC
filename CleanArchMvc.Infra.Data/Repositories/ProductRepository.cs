using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{
    class ProductRepository : IProductRepository
    {
        ApplicationDbContext _produtcContext;

        public ProductRepository(ApplicationDbContext context)
        {
            _produtcContext = context; 
        }

        public async Task<Product> CreateAsync(Product produtc)
        {
            _produtcContext.Add(produtc);
            await _produtcContext.SaveChangesAsync();
            return produtc;
        }

        public async Task<Product> GetBtyIdAsync(int? id)
        {
            return await _produtcContext.Products.FindAsync(id);
        }

        public async Task<Product> GetProductCateboryAsync(int? id)
        {
            return await _produtcContext.Products.Include(c => c.Category)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetProductyAsync()
        {
            return await _produtcContext.Products.ToListAsync();
        }

        public async Task<Product> RemoveAsync(Product produtc)
        {
            _produtcContext.Remove(produtc);
            await _produtcContext.SaveChangesAsync();
            return produtc;
        }

        public async Task<Product> UpdateAsync(Product produtc)
        {
            _produtcContext.Update(produtc);
            await _produtcContext.SaveChangesAsync();
            return produtc;
        }
    }
}
