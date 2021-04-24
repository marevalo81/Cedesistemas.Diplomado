using LoggerService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLimpia
{
    public static class ServiceExtensions
    {
        /// <summary>
        /// Servicio creado en clase para la generacion del documento
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureDocumentationService(this IServiceCollection services)
        {
            // Register the Swagger services
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "0.0.1";
                    document.Info.Title = "API limpia para probar configuracion";
                    document.Info.Description = "Api creada con los valores por defecto de .NET core";

                };
            });
        }

        /// <summary>
        /// Servicio para el manejos de logs
        /// </summary>
        /// <param name="services"></param>
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
