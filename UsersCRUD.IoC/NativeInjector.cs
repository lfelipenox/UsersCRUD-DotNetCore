using Microsoft.Extensions.DependencyInjection;
using UsersCRUD.Application.Interfaces;
using UsersCRUD.Application.Services;

namespace UsersCRUD.IoC
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
        }
    }
}