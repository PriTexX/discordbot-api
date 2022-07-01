using System.DirectoryServices;

namespace DiscordBotAPI.services;

public interface IActiveDirectoryService
{
    public DirectoryEntry GetUser(string login, string password);
}