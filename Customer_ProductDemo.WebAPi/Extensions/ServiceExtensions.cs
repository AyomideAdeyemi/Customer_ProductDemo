using Customer_ProductDemo.Application.Common;
using Customer_ProductDemo.Persistence.Common;
using Customer_ProductDemo.ServiceContract.Interfaces;
using Customer_ProductDemo.ServiceRepository.Services;
using LoggerService;
using Microsoft.EntityFrameworkCore;

namespace Customer_ProductDemo.WebAPi.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy("CorsPolicy", builder =>  builder
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod());
            });
        }
        public static void ConfigureIISIntegration(this IServiceCollection services) => services.Configure<IISOptions>(options => { });
        public static void ConfigureLoggerService(this IServiceCollection Services) => Services.AddSingleton<ILoggerManager, LoggerManager>();
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) => services.AddScoped<IServiceManager, ServiceManager>();
        public static void ConfigureSQLContext(this IServiceCollection services, IConfiguration configuration) => services.AddDbContext<RepositoryContext>(opt =>
                                                                                                                      opt.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
    }
}
