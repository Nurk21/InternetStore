using InternetStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace InternetStore.DAL
{
    public class UnitOfWork : IDisposable
    {
        private SQLDBContext db = new SQLDBContext();
        private UserRepository userRepository;
        private ProductRepository productRepository;
        private ProductPriceRepository productPriceRepository;
        private CartRepository cartRepository;

        public UserRepository Users
        {
            get
            {
                if (userRepository == null)
                    userRepository = new UserRepository(db);
                return userRepository;
            }
        }

        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }

        public ProductPriceRepository ProductPrices
        {
            get
            {
                if (productPriceRepository == null)
                    productPriceRepository = new ProductPriceRepository(db);
                return productPriceRepository;
            }
        }

        public CartRepository Carts
        {
            get
            {
                if (cartRepository == null)
                    cartRepository = new CartRepository(db);
                return cartRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}

