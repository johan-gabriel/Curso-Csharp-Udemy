using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Exercício 1");
Console.WriteLine();


Car carro = new();

carro.Acelerar();

Console.WriteLine();
Console.WriteLine("Exercício 1-a");
Console.WriteLine();

Car chevrolet = new();
chevrolet.modelo = "Sedan";
chevrolet.montadora = "Chevrolet";
chevrolet.marca = "Onix";
chevrolet.ano = 2016;
chevrolet.potencia = 110;

Console.WriteLine();
Console.WriteLine("Exercício 1-b");
Console.WriteLine();

Car ford = new();
ford.modelo = "SUV";
ford.montadora = "Ford";
ford.marca = "EcoSport";
ford.ano = 2018;
ford.potencia = 120;

Console.WriteLine();
Console.WriteLine("Exercício 1-c");
Console.WriteLine();

Console.WriteLine($" Class Chevrolet: {chevrolet.modelo}; {chevrolet.montadora}; {chevrolet.marca}; {chevrolet.ano}; {chevrolet.potencia}");
Console.WriteLine($" Class Ford: {ford.modelo}; {ford.montadora}; {ford.marca}; {ford.ano}; {ford.potencia}"); 

chevrolet.Acelerar();
ford.Acelerar();

Console.WriteLine();
Console.WriteLine("Exercício 1-d");
Console.WriteLine();

carro.AcelerarD("Mustang");

Console.WriteLine();
Console.WriteLine("Exercício 1-ef");
Console.WriteLine();

Carro carro1 = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Carro carro2 = new("SUV", "Ford", "EcoSport", 2018, 120);

carro1.AcelerarF();
carro2.AcelerarF();

Console.WriteLine();
Console.WriteLine("Exercício 1-i");
Console.WriteLine();

Carro cari = new("Mustang", "ford");
Console.WriteLine(cari.VelocidadMaxima(483));

Console.ReadKey();

public class Car
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public void Acelerar()
    { 
        Console.WriteLine("Vrum, Vrum Cachaummmmm!!!!!");
    }

    public void AcelerarD(string marca)
    { 
        Console.WriteLine($"Acelerando meu {marca}");
    }

}

public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;
    // G e H
    public Carro(string modelo, string montadora)
    {
        Modelo = modelo;
        Montadora = montadora;

        /*
         Dessa maneira podemos limitar a construção de um objeto a apenas a dois parâmetros para a class
         */
    }

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }
    public void AcelerarF()
    {
        Console.WriteLine($"Class CarroF: {Modelo} ; {Montadora} ; {Marca} ; {Ano} ; {Potencia}");
    }

    public double VelocidadMaxima(int potencia)
    {
        var r = potencia * 1.75;

        return r;
        /*
         Return retona para a função que espera ter um valor, um valor, ao invés das variáveis transportarem os valores as funções 
            também podem levar valores de funções.
         */
    }
}
