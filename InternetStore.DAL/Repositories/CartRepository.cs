using InternetStore.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DAL.Repositories
{
    public class CartRepository : IBaseRepository<Cart>
    {
        private readonly SQLDBContext _context;
        public CartRepository(SQLDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Cart entity)
        {
            await _context.Carts.AddAsync(entity);
        }
        public async Task AddItem(Product product, Guid userId)
        {
            var cart = await _context.Carts.FindAsync(userId.Equals(userId));
            cart.Products.Add(product);
        }
        public async Task RemoveItem(Product product, Guid userId)
        {
            var cart = await _context.Carts.FindAsync(userId.Equals(userId));
            cart.Products.Remove(product);
        }
        public async Task ClearCart(Guid userId)
        {
            var cart = await _context.Carts.FindAsync(userId.Equals(userId));
            cart.Products.RemoveRange(0,cart.Products.Count);
        }
    }
}
