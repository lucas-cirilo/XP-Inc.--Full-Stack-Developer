using _02_DisparandoExcecao.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

string[] linhas = File.ReadAllLines("Arquivos/Arquivo_Leitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}