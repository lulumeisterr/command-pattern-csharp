using System.Text.Json.Serialization;
using Commands;
using Commands.Interfaces;
using Configuracoes;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ProcessamentoDadosPorNotificacao.Configuracoes.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static partial class ServiceCollection
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddDependenciasNegocio(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddTransient<ICommand, GerarExcelStimulsoftCommand>();
            services.AddAutoMapper(typeof(AutoMapperConfigProfile));
            services.AddControllers().AddJsonOptions(x => { x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; });
            return services;
        }
    }
}