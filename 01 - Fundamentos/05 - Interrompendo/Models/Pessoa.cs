namespace Interrompendo.Models

// criação da classe pessoa do tipo, string. 
// para criar uma classe começo com o argumento: public class ''Nome'' da classe
// para adicionar variáveis a essa classe: public; tipo de variável. inteiro(int), texto (string) o nome da variável, e o arg: {get; set; }
// Eg: public int Idade { get; set; } ...

{
    public class Pessoa
    {
        public string Nome { get; set; } 
        public int Idade { get; set; }
        
        // Sempre ao final abrir e fechar chaves {} dentro delas colasse o get; e o set; 
        
        public void Apresentar()
        
        // ao final colocamos public void Apresentar()
        // para mostrar o código.
        
        {
           Console.WriteLine($"Olá, meu nome é {Nome}, eu tenho {Idade} anos.");
           
           // Código para escrevaer algo na tela:
           // Eg: Console.WriteLine($"Olá!,meu nome é {Nome}, e eu tenho {Idade} anos.")
           
           //outra forma de construção de código é:
           
          // Console.WriteLine($"Olá, meu nome é" +
          // $"{Nome}, eu tenho {Idade} anos.");

        }
    }
}