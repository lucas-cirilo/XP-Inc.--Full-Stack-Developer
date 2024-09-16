using _07_AlterandoLocalizacaoCultura.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // muda a cultura do sistema para en-US

decimal valorMonetario = 12482.40M;

Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //criando uma cultura específica.
