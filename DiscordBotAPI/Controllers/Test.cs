using DiscordBotAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiscordBotAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class TestController:Controller
{
    private readonly DiscordBotApiContext _dataBase;

    public TestController(DiscordBotApiContext context)
    {
        _dataBase = context;
    }

    [HttpGet]
    public string test()
    {
        return "fff";
    }
}