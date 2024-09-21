using _03_TuplaMetodo.Models;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt");

if (sucesso)
{
    Console.WriteLine($"Arquivo lido com sucesso! {quantidadeLinhas} linhas lidas!"); // Console.WriteLine($"Arquivo lido com sucesso!" + quantidadeLinhas);
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Arquivo não pode ser lido!");
}