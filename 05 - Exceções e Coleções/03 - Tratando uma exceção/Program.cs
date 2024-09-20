using _03_TratandoExcecao.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


try
{
    string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um exceção genérica: {ex.Message}");
}