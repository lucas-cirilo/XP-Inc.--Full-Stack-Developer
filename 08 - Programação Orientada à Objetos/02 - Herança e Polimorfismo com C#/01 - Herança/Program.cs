using Heranca.Models;

Aluno a1 = new Aluno();
a1.Nome = "Marcos";
a1.Idade = 25;
a1.Nota = 10;
a1.Apresentar();

Professor p1 = new Professor();
p1.Nome = "Maria";
p1.Idade = 30;
p1.Salario = 6000;
p1.Materia = "Matemática";

Console.WriteLine($" A minha professora é a {p1.Nome} e ela ganha {p1.Salario},para dar aula de {p1.Materia}, a minha nota na matéria de {p1.Materia} é {a1.Nota}."  );