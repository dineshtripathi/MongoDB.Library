using Microsoft.Extensions.DependencyInjection;

namespace MongoDB.WebApi.Client
{
    public static class WebApiConfig
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="serviceCollection"></param>
        public static void Register(IServiceCollection serviceCollection)
        {
            // Web API configuration and services
            serviceCollection.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            // Web API routes

        }
    }
}
