using _06_AlterandoLocalizacaoCodigo.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // muda a cultura do sistema para en-US

decimal valorMonetario = 12482.40M;

Console.WriteLine($"{valorMonetario:C}"); // C: Currency
