using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public interface IRepositoryBaseAsync<T> : IRepositoryBase<T>
     where T : class
    {
        Task<int> CountAsync(); // promesse de retour
        Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        Task<List<T>> GetAllAsync();

    }
}
