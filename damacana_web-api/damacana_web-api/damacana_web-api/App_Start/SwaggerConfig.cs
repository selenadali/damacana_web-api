using System.Web.Http;
using WebActivatorEx;
using damacana_web_api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace damacana_web_api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration 
                .EnableSwagger(c => {c.SingleApiVersion("v1", "damacana_web-api");})
                 
                .EnableSwaggerUi(c =>
                    {
                        
                    });
        }
    }
}


