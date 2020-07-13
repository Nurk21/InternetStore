using InternetStore.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DAL.Repositories
{
    public class ProductPriceRepository : IBaseRepository<ProductPrice>
    {
        private readonly SQLDBContext _context;
        public ProductPriceRepository(SQLDBContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(ProductPrice entity)
        {
            await _context.ProductPrices.AddAsync(entity);
        }
        // ?????
    }
}
