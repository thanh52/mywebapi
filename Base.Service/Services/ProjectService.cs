using Base.Data.IRepositories;
using Base.Data.Models;
using Base.Service.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Base.Service.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<Project>> GetAllProjectAsync()
        {
            return await _projectRepository.GetAllProjectAsync();
        }

        public async Task<Project> GetProjectByIdAsync(Guid id)
        {
            return await _projectRepository.GetProjectByIdAsync(id);
        }

        public async Task<Project> AddProjectAsync(Project newProject)
        {
            return await _projectRepository.AddAsync(newProject);
        }
    }
}
