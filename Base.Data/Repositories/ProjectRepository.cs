using Base.Data.IRepositories;
using Base.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Base.Data.Repositories
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(HTIDbContext context) : base(context)
        {
        }

        public async Task<Project> GetProjectByIdAsync(Guid id)
        {
            return await GetAll().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Project>> GetAllProjectAsync()
        {
            return await GetAll().ToListAsync();
        }
    }
}
