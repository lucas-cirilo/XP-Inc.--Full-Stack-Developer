using Foreach.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 78;
arrayInteiros[2] = 120;

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($" Posição Nº {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");

foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}

Console.WriteLine("A fim de obter uma estrutura igual ao for farei");

int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}

// Quando usar um ou outro:
// Se precisar do valor do contador usar o FOR. Caso contrário, FOREACH.