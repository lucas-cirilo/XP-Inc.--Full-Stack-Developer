using _06_IfTernario.Models;
using System.Globalization;

int numero = 152;
bool ePar = false;

// If ternário

ePar = numero % 2 == 0;

Console.WriteLine ($" O número {numero} é" + (ePar ? " par" : " impar"));


//if (numero % 2 == 0)
//{
//    Console.WriteLine($"O número {numero} é par");
//}
//else
//{
//    Console.WriteLine($"O número {numero} é impar");
//}