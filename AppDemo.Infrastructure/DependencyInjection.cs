
using AppDemo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppDemo.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services,IConfiguration configuration)
    {
        Services.AddDbContext<ApplicationDbContext>(p => p.UseSqlServer(configuration.GetConnectionString("ConnectDb")));
        return Services;
    }
}

