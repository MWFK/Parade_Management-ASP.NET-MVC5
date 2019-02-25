using System;

using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBaseAsync<T> getRepository<T>() where T : class; 
        Task CommitAsync();
        void Commit();
       
    }

}
