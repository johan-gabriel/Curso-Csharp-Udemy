/*
 Construtor:
    Os construtores são tipos especiais de métodos usados para criar e inicializar objetos de uma classe.
    Em C# toda classe precisa de um construtor para ser instanciada.
    Sempre que uma classe for instanciada usando a palavra new o seu construtor é chamdado.
    
    Ao criar uma class um construtor padrão sem parâmetros é criado automaticamente, nesse caso para
    instânciar a class.
    

Importante* 
    Se forem feitos 2 construtores para que o outro seja adicionado junto ao que possui mais valores
    é necessário adicionar o this referenciando ao atributo que o construtor menor possui.




Todos os Importante* possuem um exemplo referênciando-os!
 
 */

Console.WriteLine("## Métodos ##");

Aluno aluno = new Aluno("Johan", 26, "Macho", "S");// Constroi!
Cliente criente = new("Dedus", 22);



Referenciamento refer = new();
refer.Num1 = 25;
refer.Num2 = 26;
refer.Exibir();

Referenciamento refer2 = new();
refer2.Num1 = 38;
refer2.Num2 = 94;
refer2.Exibir();

Retorno retorno = new();
Console.WriteLine(retorno.Somar(2, 5));


MinhaClasse monhaClasse = new MinhaClasse();// criação de um novo objeto
// MinhaClasse monhaClasse = new();


monhaClasse.Saudacao(); // aciona o metodo por intermédio do objeto
aluno.ImprimeAluno();
criente.ImprimeCliente();

Console.WriteLine(monhaClasse.Soma(5, 10).ToString());


Console.ReadKey(); 

public class MinhaClasse
{
    public void Saudacao()
    {
        Console.WriteLine("Welcome To The Jungle!");
        Console.WriteLine(DateTime.Now.ToShortDateString());
        TecoTeco();
    }
    // método criado de maneira mais sucinta
    // privado pois só pode ser usado dentro da Class

    private void TecoTeco()=>
        Console.WriteLine("Bico Juice Guadalarrara!");

    public int Soma(int val1,int val2)
    {
        int resultado = val1 + val2;

        return resultado;
    }
    


}
public class Aluno
{
    // atribustos da classe!
    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
    public Aluno(string nome) => Nome = nome;
                                                                    // Importante*
    public Aluno(string nome,int idade, string sexo, string aprovado): this(nome) // no lugar de nome pode ser colocado valores que são aceitos no outro construtor
    {
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }// Meio que obriga a inicializar a class na hora de criar um objeto 

    public void ImprimeAluno()
    {
        Console.WriteLine($"Class Aluno: {Nome} ; {Idade} ; {Sexo} ; {Aprovado}");
    }
}

public class Cliente
{
    /*
     O nome do(s) atributo(s) da classe precisa ser diferênte do nome do(s) atribusto(s) do construtor!
            MAS .................!
    Se for colocado o this referênciando os atributos da classe como "diferentes" o compilador aceita
     */
    public string? Nome;
    public int Idade;

    public Cliente(string? Nome, int Idade)
    {
       this.Nome = Nome;
        this.Idade = Idade;
    }
    public void ImprimeCliente()
    {
        Console.WriteLine($"Class Cliente: {Nome} ; {Idade} ");
    }
}

public class Referenciamento
{
    public int Num1;
    public int Num2;
                                // Recebe como parâmetro o proprio tipo da classe**
    public void PassarParametro(Referenciamento t)
    {                               //Se auto referencia this ao parâmetro do método *
        Console.WriteLine($"\nthis = {this}"); // essa função mostra quem é que está sendo referenciado no método exibir
        Console.WriteLine("Num1: " + t.Num1);
        Console.WriteLine("Num2: " + t.Num2);
    }
    public void Exibir()
                    //pelo this é para se ver que é invocado o Objeto instanciado para o Exibir
    {               // retorna o parâmetro do método *
        PassarParametro(this);
    }
}

public class Retorno
{
    public int Somar(int n1, int n2) {

        int soma = n1 + n2;
        
        return soma;
    }
}



