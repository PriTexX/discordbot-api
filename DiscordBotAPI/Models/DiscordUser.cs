using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace DiscordBotAPI.Models;

public class DiscordUser
{
    [Required]
    public string DiscordUserId { get; set; }
    
    [Required]
    public string OneCGuid { get; set; }
    
    [Required]
    public string ActiveDirectoryGuid { get; set; }
}