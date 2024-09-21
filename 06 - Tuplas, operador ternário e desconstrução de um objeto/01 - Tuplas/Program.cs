using _01_Tuplas.Models;
using System.Globalization;

(int, string, string, decimal, double ) tupla = (1, "João", "Silva", 1.90M, 10000.0);

Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");
Console.WriteLine($"Salário: {tupla.Item5}");
