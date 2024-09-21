using _04_Descartes.Models;
using System.Globalization;

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, _) = arquivo.LerArquivo("Arquivos/ArquivoLeitura.txt"); // _ não usa o valor da variável

if (sucesso)
{
    //Console.WriteLine($"Arquivo lido com sucesso! {quantidadeLinhas} linhas lidas!"); // Console.WriteLine($"Arquivo lido com sucesso!" + quantidadeLinhas);
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Arquivo não pode ser lido!");
}