using _09_Dictionary.Models;
using System.Globalization;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("MG", "Minas Gerais");
estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio de Janeiro");
estados.Add("BA", "Bahia");
estados.Add("SC", "Santa Catarina");
estados.Add("PR", "Paraná");
estados.Add("RS", "Rio Grande do Sul");
estados.Add("AM", "Amazonas");
estados.Add("PA", "Pará");
estados.Add("CE", "Ceará");
estados.Add("GO", "Goiás");
estados.Add("MA", "Maranhão");
estados.Add("PB", "Paraíba");
estados.Add("PE", "Pernambuco");

foreach(var item in estados)
{
        Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
