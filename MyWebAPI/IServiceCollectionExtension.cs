using Base.Data.IRepositories;
using Base.Data.Models;
using Base.Data.Repositories;
using Base.Data.UnitOfWork;
using Base.Service.IServices;
using Base.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MyWebAPI
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HTIDbContext>(options => options.UseSqlServer(configuration["Database:HTIConnectionString"]));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IRepository<>), typeof(Repository<>))
                .AddScoped<IProjectRepository, ProjectRepository>()
                .AddScoped<IUserRepository, UserRepository>();
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IProjectService, ProjectService>()
                .AddScoped<IUserService, UserService>();
        }
    }
}
