using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Configuracoes.Extensions
{
    public static partial class ServiceCollection
    {
        public static WebApplicationBuilder AddOpenAPI(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwagger();
            return builder;
        }

        private static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(swagger =>
            {
                swagger.SwaggerDoc("v1", new OpenApiInfo()
                {
                    Description = "Command Pattern",
                    Title = "API",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Lucas Rodrigues",
                        Email = "lucasrodriguesdonascimento@outlook.com"
                    }
                });
            });
            return services;
        }

        public static IApplicationBuilder UseOpenSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(swagger =>
            {
                swagger.SwaggerEndpoint("/swagger/v1/swagger.json", "Investimentos - API");
                swagger.RoutePrefix = string.Empty;
            });
            return app;
        }
    }
}
