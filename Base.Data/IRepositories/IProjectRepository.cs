using Base.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Base.Data.IRepositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Task<Project> GetProjectByIdAsync(Guid id);

        Task<List<Project>> GetAllProjectAsync();
    }
}
