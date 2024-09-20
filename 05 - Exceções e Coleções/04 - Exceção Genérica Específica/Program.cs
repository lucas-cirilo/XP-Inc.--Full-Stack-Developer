using _04_ExcecaoGenericaEspecifica.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


try
{
    string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Diretório não encontrado: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
}