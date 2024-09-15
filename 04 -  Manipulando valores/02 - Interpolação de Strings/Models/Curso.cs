namespace _02_InterpolaçãoStrings.Models
{
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

        public bool RemoverAluno(Pessoa aluno)

        {

            return Alunos.Remove(aluno);

        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = $"Nª {count} - {Alunos[count].NomeCompleto}";    // toda interpolação começa com o símbolo de $, seguido de " 
                Console.WriteLine(texto);
            }
            
            
        }

    }
}