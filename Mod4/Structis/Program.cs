Console.WriteLine("## Structs ##");
/*
 Structs são de tipos de valor, não como as class que são tipos de referência.
   
 
 
 */
Cliente cliente = new Cliente();
cliente.Nome = "Josiscreido";
cliente.Idade = 12;
Console.WriteLine($"{cliente.Nome} {cliente.Idade}");


Console.ReadKey();

public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? Nome, int Idade)
    {
        this.Nome = Nome;
        this.Idade = Idade;
    }
}