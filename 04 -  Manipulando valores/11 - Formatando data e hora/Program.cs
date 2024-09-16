using _11_FormatandoDataHora.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

// Estrutura para trabaar com datas

DateTime data = DateTime.Now;

Console.WriteLine(data.ToShortDateString()); // elimina o horário

Console.WriteLine(data.ToShortTimeString()); // elimina a data

//posso utilizar o .Parse para converter uma string em uma data (data.Parse("dd/MM/yyyy"))