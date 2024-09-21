using _01_InstalandoNewtonsoft.Models;
using System.Globalization;

int numero = 152;
bool ePar = false;

// If ternário

ePar = numero % 2 == 0;

Console.WriteLine ($" O número {numero} é" + (ePar ? " par" : " impar"));

// para instalar o newtonsoft.json comando: dotnet add package newtonsoft.json -v 13.0.3