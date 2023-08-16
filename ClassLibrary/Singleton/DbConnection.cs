using System;

namespace ClassLibrary;
public class DbConnection
{
    public DateTime ConnectionTime { get; set; }
    public string StringConnection { get; set; }
    public string DbName { get; set; }
    //Singleton
    private static DbConnection _connection { get; set; }

    private DbConnection(string stringConnection, string dbName)
    {
        StringConnection = stringConnection;
        DbName = dbName;
        ConnectionTime = DateTime.Now;
    }

    /// <summary>
    /// This method returns the unique instance of this DBConnection singleton class.
    /// </summary>
    /// <returns>The instance of DbConnection class.</returns>
    public static DbConnection GetInstance()
    {
        if (_connection is null)
            _connection = new DbConnection("Argo", "Fiat");

        return _connection;
    }

    public void Connect()
    {
        Console.WriteLine($"A conexão com o banco {DbName} foi estabelecida com sucesso");
    }
}
