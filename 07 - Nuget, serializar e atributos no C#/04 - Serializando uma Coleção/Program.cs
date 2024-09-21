using Models;
using Newtonsoft.Json;

List<Venda> listaVendas = new List<Venda>();

Venda venda1 = new Venda(1,"Caneta", 1.50m);
Venda venda2 = new Venda(2, "lapis", 1.50m);
Venda venda3 = new Venda(3, "Borracha", 1.50m);
Venda venda4 = new Venda(4, "Caderno", 1.50m);
Venda venda5 = new Venda(5, "Apontador", 2.00m);

listaVendas.Add(venda1);
listaVendas.Add(venda2);
listaVendas.Add(venda3);
listaVendas.Add(venda4);
listaVendas.Add(venda5);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);