using _02_OutraSintaxeTuplas.Models;
using System.Globalization;

ValueTuple<int, string, string, decimal, double> OutraSintaxe = (1, "João", "Silva", 1.90M, 10000.0);
var outroexemplo = Tuple.Create(1, "João", "Silva", 1.90M, 10000.0);

Console.WriteLine($"{OutraSintaxe.Item1} {OutraSintaxe.Item2} {OutraSintaxe.Item3} {OutraSintaxe.Item4} {OutraSintaxe.Item5}");

Console.WriteLine("_________________________________________________________");

Console.WriteLine($"{outroexemplo.Item1} {outroexemplo.Item2} {outroexemplo.Item3} {outroexemplo.Item4} {outroexemplo.Item5}");
