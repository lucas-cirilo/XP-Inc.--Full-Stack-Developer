using _05_Desconstrutor.Models;
using System.Globalization;

Pessoa p1 = new Pessoa("João", "Silva");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");
