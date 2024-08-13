using Array.Common.Models;
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 78;
arrayInteiros[2] = 120;

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($" Posição Nº {contador} - {arrayInteiros[contador]}");
}
