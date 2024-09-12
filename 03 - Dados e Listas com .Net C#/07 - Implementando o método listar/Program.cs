using _07_ImplementandoListar.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Lucas";
p1.Sobrenome = "Santos";

Pessoa p2 = new Pessoa();
p2.Nome = "Luana";
p2.Sobrenome = "Ferreira";

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
