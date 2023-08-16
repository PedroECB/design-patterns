using ClassLibrary;

// See https://aka.ms/new-console-template for more information


//Singleton - Utilizando a mesma instância da classe
// DbConnection dbConnection = new DbConnection("DB1", "123");
// dbConnection.Connect();

DbConnection.GetInstance().Connect();