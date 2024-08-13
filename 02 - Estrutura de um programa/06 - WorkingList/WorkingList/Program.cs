using WorkingList.Common.Models;

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("PR");
listaString.Add("MG");

Console.WriteLine("Percorrendo a lista com o FOR");
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com o FOREACH");
int contadorForeach = 0;
foreach(string item in listaString)
{
    Console.WriteLine($"Posição Nº{contadorForeach} - {item}");
    contadorForeach++;
}