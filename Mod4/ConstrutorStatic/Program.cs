Console.WriteLine("## Construtor statico");
/*
    Construtor estático: propriedades
    Um construtor estático não usa modificadores de acesso nem tem parâmetros.
    Uma class ou struct só pode ter um único construtor estático.
    Um construtor estático não pode ser chamado diretamente.

 */
// Construtor estático acinado somente uma vez.
Pessoa peop = new Pessoa("Johan",27);

Console.WriteLine($"{peop.Nome} - {peop.Idade}");
Console.WriteLine("Idade Minima: " + Pessoa.IdadeMinima);
// Aqui apenas o primeiro construtor será acionado;
Pessoa peop2 = new Pessoa("Kabum", 14);

Console.WriteLine($"{peop2.Nome} - {peop2.Idade}");
Console.WriteLine("Idade Minima: " + Pessoa.IdadeMinima);

Console.ReadKey();

public class Pessoa
{
    public static int IdadeMinima;

    public string Nome { get; set; } = string.Empty;// não foi explicado
    public int Idade { get; set; } // não foi explicado

    public Pessoa()
    {

    }
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine("\nExecutando o construtor parametrizado");
        Nome = nome;
        Idade = idade;
    }

    static Pessoa() 
    {
        Console.WriteLine("\nExecutando o construtor estático");
        Console.WriteLine("Inicializando o campo IdadeMinima");
        IdadeMinima = 18;
    }


}