using DatingApp.Data;
using DatingApp.Interfaces;
using DatingApp.Services;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(config.GetConnectionString("connectionString"))
            );
            //add core here
            // services.AddCors();
            services.AddScoped<ITokenService, TokenService>();
            return services;
        }
    }
}
