using DiscordBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiscordBotAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly DiscordBotApiContext _database;

    public LoginController(DiscordBotApiContext context)
    {
        _database = context;
    }

    [HttpGet]
    public string Get()
    {
        return "get request";
    }
    
    [HttpPost]
    public UserCredentials Post(UserCredentials credentials)
    {
        return credentials;
    }
}