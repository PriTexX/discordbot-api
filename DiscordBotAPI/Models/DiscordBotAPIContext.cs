using Microsoft.EntityFrameworkCore;

namespace DiscordBotAPI.Models;

public class DiscordBotApiContext : DbContext 
{
    public DiscordBotApiContext(DbContextOptions<DiscordBotApiContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<DiscordUser> DiscordUsers { get; set; }
}