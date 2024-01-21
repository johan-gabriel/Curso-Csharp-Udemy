/*
 Assinatura do método:
    - como o compilador identifica os metodos;
 Cada método tem a assinatura:
    - Nome do método
    - O número de parâmetros
    - O tipo dos parâmetros
    - A ordem dos parâmetros
  O tipo de retorno não faz parte da assinatura;

  A Class Calculadora faz a definição do que é sobre carga de métodos:
    - os métodos entre si utilizam os atributos no caso para serem diferenciádos
    - util quando é necessário usar tipos de dados variados
    No caso se eu quiser:
    somar 3 valores = eu consigo
    somar 2 valores = consigo
    um bouble + um int = consigo
    valor futuante ou não = consigo
 
 */


Console.WriteLine("## Métodos Avançados ##");
Console.WriteLine();

  
Cadastro cadastro = new Cadastro();
//Nesse caso tenho valores dinamicos pois a classe Cadastro autera automaticamente o Cliente.
var cliente = cadastro.Registrar(); // cliente aqui como var é uma instancia desse cadstro.Registrar()
cadastro.ExibirDados(cliente);

//alterar a renda

cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda Alterada", cliente);





Console.ReadKey();

public class Calculadora
{
    public int Somar(int num1,int num2)
    {

        return num1 + num2;
    }

    public int Somar(int num1, int num2, int num3)
    {

        return num1 + num2 + num3;
    }
    public double Somar(double num1, double num2)
    {

        return num1 + num2;
    }
    public double Somar(int num1, double num2)
    {

        return num1 + num2;
    }
    
}
public class Cliente
{
    public string? Nome;
    public int Idade;
    public decimal Renda;

    public Cliente (string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }
    public Cliente()
    {
        // Este construtor é produzido vazio por haver a possibilidade de instanciar o objeto sem parametros!
        //Mas uma maneira de utilizar uma sobre carga
    }
}
public class Cadastro
{
    public Cliente Registrar() // A função do tipo de retorno "Cliente" retorna um Obj da class Cliente para uma var
    {
        Cliente cliente = new("Maria", 23, 3000); // Aqui consigo atribuir os dados a class Cliente
        return cliente;
    }

    public Cliente Registrar(Cliente cliente) // Função para alterar a renda para 3500
    {
        cliente.Renda = 3500;
        return cliente;
    }

    public void ExibirDados(Cliente cliente) =>                               //Serve para colocar o valor dado na moeda local (R$)
          Console.WriteLine($"{cliente.Nome}; {cliente.Idade}; {cliente.Renda.ToString("c")}");

    public void ExibirDados(string texto, Cliente cliente) // Exibe a renda com um texto arbitrario
    {
        Console.WriteLine($"\n{texto}\t");
        Console.WriteLine($"{cliente.Nome} - {cliente.Renda.ToString("c")}");
    }
}