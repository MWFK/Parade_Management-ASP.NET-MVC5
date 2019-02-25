using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
       
         private DefileContext dataContext;

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
            dataContext = dbFactory.DataContext;
        }   
        public void Commit()
        {
            dataContext.SaveChanges();
        }
         public async Task  CommitAsync() // il manque task et wail
         {
             await dataContext.SaveChangesAsync();
         }
        public void Dispose()
        {
            dataContext.Dispose();
        }
        public IRepositoryBaseAsync<T> getRepository<T>() where T : class
        {
            IRepositoryBaseAsync<T> repo = new RepositoryBase<T>(dbFactory);
            return repo;
        }
    }
}
