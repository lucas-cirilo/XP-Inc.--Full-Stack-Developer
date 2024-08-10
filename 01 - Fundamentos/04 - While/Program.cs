using While.Models;

int numero = 5;
int contador = 1; // Troquei de 0 para 1, para remover o 5x0 = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
}