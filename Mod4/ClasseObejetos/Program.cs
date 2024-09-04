Console.WriteLine("Hello, World!");

int x = 100;
// criando objetos da classe pessoa
Pessoa p1 = new Pessoa();
p1.nome = "Johann";// o ponto eu acesso o atributo do objeto!
p1.idade = 27;
p1.sexo = "Macho alpha";

Console.WriteLine($"{p1.nome}, {p1.idade} , {p1.sexo}");

Pessoa p2 = new Pessoa();
p1.nome = "Kivia";
p1.idade = 28;
p1.sexo = "Gata";

Console.WriteLine($"{p2.nome}, {p2.idade} , {p2.sexo}");


Console.ReadKey();


class Pessoa
{
    // Atributos da classe
    public string? nome; // A interrogação serve para ? = nullableType. Ou seja tipo de variável anulável
    public int idade;
    public string? sexo;
}

public class Aluno
{
    public string? Nome;
    public int? idade;
    public string? sexo;
    public string? Aprovado;
}

public class Curso
{
    public void Resultado(string? nome, int? idade,string? sexo,string? aprovado)
    {
        Console.WriteLine($"O Aluno:{nome}, Idade:{idade}, Sexo:{sexo}");

        if (aprovado == "S") { Console.WriteLine("Foi aprovado"); }
        else { Console.WriteLine("Foi reprovado"); }
    }
}