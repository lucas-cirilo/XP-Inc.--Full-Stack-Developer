﻿string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        
        case "2":
            Console.WriteLine("Busca de cadastro");
            break;
        
        case "3":
            Console.WriteLine("Apagar cadastro");
            break;
        
        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;
        
        default:
            Console.WriteLine("opção inválida");
            break;
    }
}