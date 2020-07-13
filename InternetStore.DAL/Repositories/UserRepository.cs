using InternetStore.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DAL.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly SQLDBContext _context;
        public UserRepository(SQLDBContext context)
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            //при создании юзера создавать корзину этого юзера
        }
        public async Task DeleteByIdAsync(Guid userId)
        {
           var user = await _context.Users.FindAsync(userId);
           _context.Remove(user);
        }
        // апдейт юзера?
    }
}
