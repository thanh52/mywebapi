using System.Linq;
using System.Threading.Tasks;

namespace Base.Data.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> AddAsync(TEntity entity);

        TEntity Update(TEntity entity);
        TEntity Find(object id);
    }
}
