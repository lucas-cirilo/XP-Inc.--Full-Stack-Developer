using _13_ValidandoRetornoTryParse.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


string dataString = "48/03/2023 12:30:00";


bool sucesso = DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    Console.WriteLine($"Convertido com sucesso! Data: {data}");
}
else
{
    Console.WriteLine($"{data} não é uma data válida, a conversão falhou.");
}

Console.WriteLine(data);
