using Microsoft.EntityFrameworkCore;
using Multitenant.Data;
using Multitenant.Extensions;

namespace Multitenant.IoC
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHttpContextAccessor();

            services.AddDbContext<MultitenantContext>();


            //Mudando ConnectionString de Acordo com o tenant
            services.AddScoped<MultitenantContext>(x =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<MultitenantContext>();

                var tenantId = x.GetService<IHttpContextAccessor>()?.HttpContext.GetTenantId() ?? "Google";

                var connectionString = configuration.GetConnectionString(tenantId);

                optionsBuilder
                .UseSqlServer(connectionString);

                return new MultitenantContext(optionsBuilder.Options);
            });

            return services;
        }
    }
}
