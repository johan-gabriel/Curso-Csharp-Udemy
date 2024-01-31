Console.WriteLine("## Propriedades ##");
/*
 Uma Propriedade é um membro da class que fornece um mecanismo para ler, gravar ou calcular o valor de um campo privado.

 As propriedades podem ser usadas como se fossem membros de dados públicos, mas possuem métodos especiais chamados acessadores.

 Esse recurso permite que os dados sejam acessados com facilidade e ainda ajuda a promover a segurança e a flexibilidade dos métodos.

 RESUMO: As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores, equanto oculta o código de 
implementação ou verificação.

 
 */

Produto p1 = new();
p1.Nome = "Caderno";
p1.Preco = 10.00;
//p1.Desconto = 0.05;
p1.PrecoFinal = p1.Preco - p1.Preco * p1.Desconto;
p1.EstoqueMinimo = 10;

p1.Exibir();

Console.ReadKey();


public class Pessoa
{
    private string nome;// Campo

    public string Nome // Propriedade
    {
        get { return nome; }
        set { nome = value; }
    }

    // maneira resumida
    public int Idade { get; set; }
}

public class Produto
{
    private string nome;// tem que possuir um se não não for utilizar da maneira padrão.
    public string? Nome 
    {
        get { return nome.ToUpper(); } 
        set { nome = value; }
    }

    private double preco;
    public double Preco 
    {
        get { return preco; }
        set
        {
            if (value < 5.00)
                preco = 5.00;
            else
                preco = value;
        }

    }
    private double desconto = 0.05; // valor padrão atribuido a esse Parâmetro
    public double Desconto 
    {
        get { return desconto; } 
    }
    public double PrecoFinal { get; set;}
    public int EstoqueMinimo { get;set; }


    public void Exibir()
    {
        Console.WriteLine($"{Nome}: \n{Preco.ToString("c")} \n {Desconto} \n{PrecoFinal.ToString("c")} \n{EstoqueMinimo}");
    }

}