﻿using Models;
using Newtonsoft.Json;

Venda venda1 = new Venda(1,"caneta", 1.50m);

string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);