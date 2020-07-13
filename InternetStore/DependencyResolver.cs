using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InternetStore
{
    public static class DependencyResolver
    {
        public static void Resolve(IServiceCollection services, IConfiguration configuration)
        {
            var appSettingSection = configuration.GetSection("AppSettings");
            //services.Configure<AppSettings>(appSettingSection);
            services.AddMemoryCache();
            services.AddRouting();
            Repositories(services);
            Services(services);
            Validators(services);
        }


        private static void Validators(IServiceCollection services)
        {
            //services.AddScoped<IClientPaymentDataValidator, ClientPaymentDataValidator>();

        }

        private static void Services(IServiceCollection services)
        {
            //services.AddMediatR(Assembly.GetExecutingAssembly());
            //services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(Startup));
            //services.AddScoped<IGetDataFromDBThroughWINTService, GetDataFromDBThroughWINTService>();
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            //});
            //services.AddHttpClient();
        }

        private static void Repositories(IServiceCollection services)
        {

            //services.AddScoped<IMongoRepository<SuccessfulRepairDTO>, MongoRepository<SuccessfulRepairDTO>>();
        }
    }
}
