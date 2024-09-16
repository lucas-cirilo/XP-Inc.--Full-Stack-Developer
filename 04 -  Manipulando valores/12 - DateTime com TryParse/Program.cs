using _12_DateTimeTryParse.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura


string dataString = "48/03/2023 12:30:00";

//utilizando o TryParseExact para converter a string em uma data, para não estourar uma exceção que encerraria o código, assim fica mais seguro.
//o TryParseExact recebe 5 parâmetros: a string, o formato da data, a cultura, os estilos e a data
//DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);


DateTime.TryParseExact(dataString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

Console.WriteLine(data);
//posso utilizar o .Parse para converter uma string em uma data (data.Parse("dd/MM/yyyy"))