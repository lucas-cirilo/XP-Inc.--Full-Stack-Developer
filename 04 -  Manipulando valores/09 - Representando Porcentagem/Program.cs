using _09_RepresentandoPorcentagem.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // muda a cultura do sistema para en-US

decimal valorMonetario = 12482.40M;

Console.WriteLine(valorMonetario.ToString("C1")); // C1 = quantas casas decimais ele vai representar

// se for N1 = vai considerar como um número

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P1")); // P1 = quantas casas decimais ele vai representar

int dataNascimento = 24061997;

Console.WriteLine(dataNascimento.ToString("##-##-####")); // # = qualquer número - = separador