using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using DiscordBotAPI.Models;

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
        services.AddControllers();
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
