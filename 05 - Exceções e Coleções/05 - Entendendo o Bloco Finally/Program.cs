using _05_EntendendoBlocoFinally.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


try
{
<<<<<<< HEAD
    string[] linhas = File.ReadAllLines("Arquivos/ArquivoLeitura.txt");
=======
    string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");
>>>>>>> origin/main
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
<<<<<<< HEAD
}
finally
{
        Console.WriteLine("Chegastes ao fim do programa");
=======
>>>>>>> origin/main
}