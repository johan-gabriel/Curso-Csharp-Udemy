Console.WriteLine("## Tipos Anonimos ##");
Console.WriteLine();
var aluno = new
{
    Nome = "Johan", // não é declarado o tipo da variável.
    Idade = 27

};
Console.WriteLine($"{aluno.Nome} - {aluno.Idade}");

var colegio = new
{
    Endereco = new { Id = 1, Cidade = "Santos", Pais = "Brasil" },
    Nome = "Colegio Minerador",
    Email = "colminerador@email.com"
};
Console.WriteLine($"\n{colegio.Endereco.Cidade} - {colegio.Nome} - {colegio.Email}");
var condominio = new[]
{
    new{Id = 1, Numero = 10, Responsavel = new{Nome ="Bete", Cargo = "Condômina", Idade = 47}},
    new{Id = 2, Numero = 12, Responsavel = new{Nome ="Johan", Cargo = "Síndico", Idade = 27}}
};
Console.WriteLine($"\n{condominio[0].Id} - {condominio[0].Numero} - {condominio[0].Responsavel.Nome} - {condominio[0].Responsavel.Idade}");



Console.ReadKey();
