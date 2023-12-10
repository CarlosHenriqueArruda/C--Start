using PMC.Models;


Pessoa p1 = new Pessoa(nome:"Carlos",sobrenome:"Arruda");
Pessoa p2 = new Pessoa(nome:"Ranielly",sobrenome:"Arruda");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();


cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();