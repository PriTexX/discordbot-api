using DiscordBotAPI.Models;
using DiscordBotAPI.services;
using Microsoft.AspNetCore.Mvc;

namespace DiscordBotAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LoginController : ControllerBase
{
    private readonly DiscordBotApiContext _database;
    private readonly IActiveDirectoryService _activeDirectory;

    public LoginController(DiscordBotApiContext context, IActiveDirectoryService adService)
    {
        _database = context;
        _activeDirectory = adService;
    }

    [HttpPost]
    public IActionResult Post(UserCredentials credentials)
    {
        if (credentials.Login == "v.a.bulavin" && credentials.Password == "Stud336266!")
        {
            var stInfo = new StudentInfo{
                Name = "Владислав",
                Surname = "Булавин",
                Department = "Информационные системы и технологии", 
                Group = "211-721",
                ActiveDirectoryGuid = "123456789",
                OneCGuid = "987654321"
            };
            return new ObjectResult(stInfo);
        }

        return BadRequest(credentials);
    }
}