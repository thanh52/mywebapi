using Base.Data.IRepositories;
using Base.Data.Models;
using Base.Data.UnitOfWork;
using Base.Service.IServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Base.Service.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProjectRepository _projectRepository;

        public ProjectService(IUnitOfWork uow, IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
            _unitOfWork = uow;
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
            var rs = await _projectRepository.AddAsync(newProject);
            await _unitOfWork.CommitAsync();
            return rs;
        }
    }
}
