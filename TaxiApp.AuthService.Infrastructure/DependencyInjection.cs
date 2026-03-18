using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TaxiApp.AuthService.Application.Interfaces;
using TaxiApp.AuthService.Infrastructure.Authentication;
using TaxiApp.AuthService.Infrastructure.Persistence;
using TaxiApp.AuthService.Infrastructure.Repositories;
using TaxiApp.AuthService.Infrastructure.Security;
using TaxiApp.AuthService.Infrastructure.Security.TaxiApp.AuthService.Infrastructure.Security;

namespace TaxiApp.AuthService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<AuthDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));

        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IPasswordHasher, PasswordHasher>();
        services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();

        return services;
    }
}