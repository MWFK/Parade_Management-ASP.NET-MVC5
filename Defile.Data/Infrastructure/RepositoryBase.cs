using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public class RepositoryBase<T> : IRepositoryBaseAsync<T> where T : class
    {
        private DefileContext dataContext;
        private readonly IDbSet<T> dbset;
        IDatabaseFactory databaseFactory;
        public RepositoryBase(IDatabaseFactory dbFactory)
        {
            this.databaseFactory = dbFactory;
            dbset = DataContext.Set<T>();


        }
        protected DefileContext DataContext
        {
            get { return dataContext = databaseFactory.DataContext; }
        }

        #region Synch Methods
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();//dbset source de données
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        //public virtual IEnumerable<T> GetAll() // dans getMany si on ne passe rien comme condition
        //{
        //    return dbset.ToList();
        //}

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            return Query;
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        } 
        #endregion

   
        #region Async methos


        public async Task<int> CountAsync()
        {
            return await dbset.CountAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.SingleOrDefaultAsync(match); // ne bloque pas
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.Where(match).ToListAsync();
        }
        #endregion
    }
}
