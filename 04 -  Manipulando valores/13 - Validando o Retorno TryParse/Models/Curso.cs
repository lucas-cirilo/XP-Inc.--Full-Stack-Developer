namespace _13_ValidandoRetornoTryParse.Models
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
                string texto = $"Nª {count + 1} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
            
            // outra maneira seria ajustar a numeração é
           // criar uma variável int exibicao = count +1, e colocá-la dentro das {}
        }

    }
}