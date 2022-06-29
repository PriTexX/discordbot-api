using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;

namespace DiscordBotAPI.Models;

public class DiscordUser
{
    [Required]
    [Key]
    public int UserId { get; set; }
    
    [Required]
    public Guid OneCId { get; set; }
    
    [Required]
    public Guid ActiveDirectoryId { get; set; }
}