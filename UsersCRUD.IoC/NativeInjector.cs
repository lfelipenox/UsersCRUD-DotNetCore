using Microsoft.Extensions.DependencyInjection;
using UsersCRUD.Domain.Interfaces;
using UsersCRUD.Application.Interfaces;
using UsersCRUD.Application.Services;
using UsersCRUD.Data.Repositories;

namespace UsersCRUD.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            #region Services
            
            services.AddScoped<IUserService, UserService>();

            #endregion

            #region Repositories

            services.AddScoped<IUserRepository, UserRepository>();

            #endregion
        }
    }
}