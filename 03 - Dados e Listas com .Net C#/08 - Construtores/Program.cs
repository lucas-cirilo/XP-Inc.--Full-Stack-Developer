using _08_Construtores.Models;

Pessoa p1 = new Pessoa("Lucas", "Santos"); // usando o construtor

Pessoa p2 = new Pessoa();
p2.Nome = "Luana";
p2.Sobrenome = "Fernandes";

Pessoa p3 = new Pessoa();
p3.Nome = "Thays";
p3.Sobrenome = "Moura";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
