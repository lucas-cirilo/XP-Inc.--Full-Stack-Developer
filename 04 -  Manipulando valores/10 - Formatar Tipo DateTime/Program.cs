using _10_FormatarTipoDateTime.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

// Estrutura para trabaar com datas

DateTime data = DateTime.Now;

Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));