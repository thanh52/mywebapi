using Base.Data.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Base.Service.IServices
{
    public interface IProjectService
    {
        Task<Project> GetProjectByIdAsync(Guid id);

        Task<List<Project>> GetAllProjectAsync();
        Task<Project> AddProjectAsync(Project project);
    }
}
