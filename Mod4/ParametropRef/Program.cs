Console.WriteLine("Parâmetros por Referência");
Console.WriteLine();

int x = 20;
Console.WriteLine("\n Valor do argumento x antes: " + x);
Console.WriteLine();

Calculo calc = new();
calc.Dobrar(ref x);// Declara por referência 

Console.WriteLine("\nValor do argumento x depois: " + x);//Altera o valor !!!!

Console.ReadKey();

public class Calculo
{
    public void Dobrar(ref int y) // Por Referência
    {
        y *= 2;
        Console.WriteLine("\nValor do Parâmetro no método Dobrar " + y);
    }
}