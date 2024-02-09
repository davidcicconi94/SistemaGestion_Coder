using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData.Context
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("ApplicationDbContext");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
    }
}
