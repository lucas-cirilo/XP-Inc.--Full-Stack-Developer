namespace ImplementandoClasse.Models;

public class Curso
{
    public string Nome { get; set; }
    public List<Pessoa> Alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }

    public int QuantidadeAlunosMatriculados()
    {
        int quantidade = Alunos.Count;

        return quantidade;
        
    }
}