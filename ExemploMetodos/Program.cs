// See https://aka.ms/new-console-template for more information

using ExemploMetodos.models;

Pessoa p1 = new Pessoa();
p1.Nome = "Giancarlo";
p1.Sobrenome = "Massaccesi";

Pessoa p2 = new Pessoa();
p2.Nome = "Eduardo";
p2.Sobrenome = "Neves Queiroz";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();
