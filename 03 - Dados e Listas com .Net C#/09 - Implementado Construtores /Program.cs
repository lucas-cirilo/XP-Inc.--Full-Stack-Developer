using _09_Implementando_Construtores.Models;

Pessoa p1 = new Pessoa(nome: "Lucas", sobrenome: "Santos"); // usando o construtor
Pessoa p2 = new Pessoa(nome:"Juliana", sobrenome: "Oliveira");
Pessoa p3 = new Pessoa(nome: "Thays", sobrenome: "Moura");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
