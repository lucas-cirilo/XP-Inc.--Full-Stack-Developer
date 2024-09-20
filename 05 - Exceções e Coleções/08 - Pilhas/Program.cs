using _08_Pilhas.Models;
using System.Globalization;

Stack<int> pilha = new Stack<int>(); // cria uma pilha de inteiros

pilha.Push(1); // empilha o elemento 1
pilha.Push(2); // empilha o elemento 2
pilha.Push(3); // empilha o elemento 3

foreach (int item in pilha)
{
    Console.WriteLine(item); // exibe os elementos da pilha (1, 2, 3)
}

Console.WriteLine($"Removendo o elemento do topo da pilha: {pilha.Pop()}"); // remove o elemento do topo da pilha (3)

pilha.Push(4); // empilha o elemento 4

foreach (int item in pilha)
{
    Console.WriteLine(item); // exibe os elementos da pilha
}
