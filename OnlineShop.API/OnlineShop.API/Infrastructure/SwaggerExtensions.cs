using Microsoft.OpenApi.Models;

namespace OnlineShop.API.Infrastructure
{
    public static class SwaggerExtensions
    {
        public static void AddSwaggerDoc(this IServiceCollection services)
        {
            services.AddSwaggerGen(o =>
            {
                o.EnableAnnotations();
                o.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Online Shop API"
                });
            });
        }

        public static void UseSwaggerDoc(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
