using Base.Data.IRepositories;
using Base.Data.Models;
using Base.Data.Repositories;
using System.Threading.Tasks;

namespace Base.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HTIDbContext _htiDbContext;
        public IProjectRepository Project;

        public UnitOfWork(HTIDbContext db)
        {
            _htiDbContext = db;
            Project = new ProjectRepository(_htiDbContext);
        }

        public void Dispose()
        {
            _htiDbContext.Dispose();
        }

        public Task<int> CommitAsync()
        {
            return _htiDbContext.SaveChangesAsync();
        }
    }
}
