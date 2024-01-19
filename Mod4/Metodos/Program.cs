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


MinhaClasse monhaClasse = new MinhaClasse();// criação de um novo objeto
// MinhaClasse monhaClasse = new();


monhaClasse.Saudacao(); // aciona o metodo por intermédio do objeto

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
    public Aluno(string nome) => Nome = nome;
                                                                    // Importante*
    public Aluno(string nome,int idade, string sexo, string aprovado): this(nome)
    {
        
        Idade = idade;
        Sexo = sexo;
        Aprovado = aprovado;
    }// Meio que obriga a inicializar a class na hora de criar um objeto

    public string? Nome;
    public int Idade;
    public string? Sexo;
    public string? Aprovado;
}

