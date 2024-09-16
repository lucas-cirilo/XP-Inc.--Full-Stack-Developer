using _08_FormataçãoPersonalizada.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // muda a cultura do sistema para en-US

decimal valorMonetario = 12482.40M;

Console.WriteLine(valorMonetario.ToString("C1")); // C1 = quantas casas decimais ele vai representar

// se for N1 = vai considerar como um número
