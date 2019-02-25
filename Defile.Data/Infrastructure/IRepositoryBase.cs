using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Defile.Data.Infrastructure
{
    public interface IRepositoryBase<T>
     where T : class
    {
        void Add(T entity);
        void Delete(Expression<Func<T, bool>> where);// expression lambda
        void Delete(T entity); 
        T Get(Expression<Func<T, bool>> where);// expression lambda qui retourne un seul objet

        T GetById(long id);
        T GetById(string id);
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, 
            Expression<Func<T, bool>> orderBy = null); // factorisation en une seule méthode

        void Update(T entity);


    }
}
