using CopyingArray.Common.Models;

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72; 
arrayInteiros[1] = 78;
arrayInteiros[2] = 120;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteirosDobrado.Length; contador++)
{
    Console.WriteLine($" Posição Nº {contador} - {arrayInteirosDobrado[contador]}");
}