using System.Globalization;
using ClassLibrary;

// See https://aka.ms/new-console-template for more information


/* SINGLETON */
// Utilizando a mesma instância da classe
// DbConnection dbConnection = new DbConnection("DB1", "123");
// dbConnection.Connect();

// DbConnection instance1 = DbConnection.GetInstance();
// DbConnection instance2 = DbConnection.GetInstance();
// instance1.Connect();
// instance1.Connect();


/* STRAGEGY */
// Utilizando variações de um algoritmo específico e aplicando em classes distintas

TaxContext taxContext = new TaxContext();
taxContext.SetTaxStrategy(new TaxSchoolStrategy());
decimal valueTaxSchool = taxContext.ExecuteStrategy(10000);

taxContext.SetTaxStrategy(new TaxPersonStrategy());
decimal valueTaxClient = taxContext.ExecuteStrategy(10000);

taxContext.SetTaxStrategy(new TaxCarStrategy());
decimal valueTaxCar = taxContext.ExecuteStrategy(10000);


Console.WriteLine($"Valor da taxa  a ser pago pela escola: {valueTaxSchool.ToString("C2", CultureInfo.CurrentCulture)}");
Console.WriteLine($"Valor da taxa  a ser pago pelo cliente: {valueTaxClient.ToString("C2", CultureInfo.CurrentCulture)}");
Console.WriteLine($"Valor da taxa  a ser pago pelo dono do carro: {valueTaxCar.ToString("C2", CultureInfo.CurrentCulture)}");


