namespace _06_UsandoThrow.Models;

public class Pessoa
{
    public Pessoa()
    {
        
    }
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    private int _idade;
    private string _nome;

    public string Nome

    {
        get => _nome.ToUpper();

        set
        {
            if (value == "") throw new ArgumentException("O nome não pode ser vazio");

            _nome = value;
        }
    }

    public string Sobrenome { get; set; }

    public string NomeCompleto => $"{Nome} {Sobrenome}" .ToUpper();
    
    public int Idade
    {
        get => _idade;

        set
        {
            if (value <= 0) throw new ArgumentException("A Idade não pode ser igual ou menor que 0");

            _idade = value;
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Nome:{NomeCompleto}, idade: {Idade}.");
    }
}