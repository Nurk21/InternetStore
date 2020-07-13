using InternetStore.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DAL.Repositories
{
    public class ProductRepository : IBaseRepository<Product>
    {
        private readonly SQLDBContext _context;
        public ProductRepository(SQLDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Product entity)
        {
            await _context.Products.AddAsync(entity);
            // продакт прайс?
        }
        public async Task DeleteByIdAsync(Guid productId)
        {
            var product = await _context.Users.FindAsync(productId);
            _context.Remove(product);
        }
        // апдейт продукта?
        
    }
}
