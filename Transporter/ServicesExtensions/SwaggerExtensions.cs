using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Transporter
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "API",
                    Description = "Test API with ASP.NET Core 3.0",
                    TermsOfService = "None",
                    Contact = new Contact()
                    {
                        Name = "Dotnet Detail",
                        Email = "dotnetdetail@gmail.com",
                        Url = "www.dotnetdetail.net"
                    },
                    License = new License
                    {
                        Name = "ABC",
                        Url = "www.dotnetdetail.net"
                    },
                });

            });
        }

    }
}
