using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Shop.Business.DependencyResolvers.Autofac;

namespace Shop.WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var host = CreateHostBuilder(args).Build();
            host.Run();

            // Autofac kullanýmý için DI konteynerini yapýlandýrma
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule(new AutofacBusinessModule());

            // WebApplicationBuilder nesnesi üzerinden gerekli servisleri ekleyin
            builder.Services.AddControllers();
            builder.Services.AddAuthorization();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Autofac DI konteynerini oluþturun ve gerekli servisleri DI konteynerine ekleyin
            containerBuilder.Populate(builder.Services);
            var container = containerBuilder.Build();

            var app = builder.Build();

            // Middleware'leri ekle
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    builder.RegisterModule(new AutofacBusinessModule());
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
