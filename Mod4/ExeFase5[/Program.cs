using System.Transactions;

Console.WriteLine("Exe. 1; 2 e 3");
Console.WriteLine();
Carro car = new();

car.ExibirInfo("Sedan", "Ford", "Mustang", 486);

Console.WriteLine();

car.ExibirInfo("Sedan", "Nissan", "GTsupra", 520, 2015);


Console.ReadKey();


public class Carro
{
    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2024)
    {
        Console.WriteLine($" {modelo} - {montadora} - {marca} - {potencia} - {ano}");
    }
}
