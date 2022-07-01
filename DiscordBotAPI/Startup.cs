using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using DiscordBotAPI.Models;
using DiscordBotAPI.services;

namespace DiscordBotAPI;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }
 
    public IConfiguration Configuration { get; }
 
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DiscordBotApiContext>(options => 
            options.UseInMemoryDatabase("TestDatabase"));
        services.AddControllers()
            .AddJsonOptions(o =>
            {
                o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });

        services.AddSingleton<IActiveDirectoryService, ActiveDirectoryService>(
            x => new ActiveDirectoryService("mytestdomen.ru")
            );
    }
 
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
 
        app.UseHttpsRedirection();
 
        app.UseRouting();
 
        app.UseAuthorization();
 
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}
