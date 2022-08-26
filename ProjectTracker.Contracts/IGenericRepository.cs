using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Contracts
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> All();
        Task<IEnumerable<TEntity>> GetData(string qry, object parameters);
        Task<TEntity> FindAsync(object pksFields);
        Task<int> Add(TEntity entity);
        Task<int> Add(IEnumerable<TEntity> entities);
        Task Remove(object key);
        Task<int> Update(TEntity entity, object pks);
        Task<int> InstertOrUpdate(TEntity entity, object pks);
    }
}
