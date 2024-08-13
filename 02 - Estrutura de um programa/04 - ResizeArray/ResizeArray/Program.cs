using ResizeArray.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72; 
arrayInteiros[1] = 78;
arrayInteiros[2] = 120;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($" Posição Nº {contador} - {arrayInteiros[contador]}");
}