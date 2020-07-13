using InternetStore.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InternetStore.DAL.Repositories
{
    public interface IBaseRepository<T> where T : IIdentifiable
    {
        Task AddAsync(T entity); 
    }
}
