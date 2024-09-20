using _13_ValidandoRetornoTryParse.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}