using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;

namespace DiscordBotAPI.services;

public class ActiveDirectoryService : IActiveDirectoryService
{
    private readonly string _connectionString;

    public ActiveDirectoryService(string domainName)
    {
        _connectionString = "LDAP://" + domainName;
    }

    public DirectoryEntry GetUser(string login, string password)
    {
        var de = new DirectoryEntry(_connectionString, login, password);
        return de;
    }
}