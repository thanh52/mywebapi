using System;
using System.Threading.Tasks;

namespace Base.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        Task<int> CommitAsync();
    }
}
