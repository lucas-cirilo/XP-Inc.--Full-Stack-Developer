using _07_Filas.Models;
using System.Globalization; // adiciona a biblioteca para usar a cultura

Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(5);
fila.Enqueue(6);

foreach (int item in fila )
{
    Console .WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // remove o primeiro elemento da fila.
fila.Enqueue(7);

foreach (int item in fila )
    {
        Console .WriteLine(item);
    }