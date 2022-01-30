using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RestApiFiles.Data;

namespace RestApiFiles.DI
{
    public static class DataLite
    {
        public static IServiceCollection AddDataLite(this IServiceCollection services,
            IConfiguration configuration)
        {
            var environmentConnectionString = Environment.GetEnvironmentVariable("connectionString");
            services.AddDbContext<FilesDbContext>(options =>
                options.UseSqlite(environmentConnectionString ??
                                  configuration.GetConnectionString("connectionString")));
            services.AddTransient<DbContext, FilesDbContext>();
            return services;
        }
    }
}