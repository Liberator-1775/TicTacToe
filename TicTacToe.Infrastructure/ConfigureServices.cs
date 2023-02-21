using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TicTacToe.Application.Common;
using TicTacToe.Domain.Identity;
using TicTacToe.Infrastructure.Persistence;
using TicTacToe.Infrastructure.Repositories;

namespace TicTacToe.Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        return services.AddDbContext<ApplicationDbContext>(builder =>
                builder.UseNpgsql(configuration.GetConnectionString("Default")))
            .AddScoped<IApplicationDbContext, ApplicationDbContext>()
            .AddTransient<IRepository<User, string>, UserRepository>()
            .AddTransient<IRepository<Role, string>, RoleRepository>();
    }
}