using Microsoft.Extensions.Configuration;
public class MySqlCustomInfos
{
    private readonly string _server;
    private readonly string _database;
    private readonly string _user;
    private readonly string _password;

    public MySqlCustomInfos()
    {
        var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

        _server = config["db:server"]!;
        _database = config["db:database"]!;
        _user = config["db:user"]!;
        _password = config["db:password"]!;
    }

    public string ConnectionString
    {
        get
        {
            string connectionString = $"Server={_server};Database={_database};Uid={_user};Pwd={_password}";
            return connectionString;
        }
    }
}