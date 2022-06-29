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

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<DiscordBotApiContext>(options => 
            options.UseInMemoryDatabase("TestDatabase")); //сделали подключение к базе данных
        services.AddControllers()
            .AddJsonOptions(o =>
            {
                o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
            });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseHsts();
     

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=WeatherForecast}/{action=GetWeatherForecast}/{id?}");
        });
    }
}