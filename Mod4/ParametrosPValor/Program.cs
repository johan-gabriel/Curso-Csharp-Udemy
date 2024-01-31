Console.WriteLine("Parâmetros por valor");
Console.WriteLine();

int x = 20;
Console.WriteLine("\n Valor do argumento x antes: " + x);
Console.WriteLine();

Calculo calc = new();
calc.Dobrar(x); 

Console.WriteLine("\nValor do argumento x depois: " + x);// nenhuma novidade

Console.ReadKey();

public class Calculo
{
    public void Dobrar(int y)
    {
        y *= 2;
        Console.WriteLine("\nValor do Parâmetro no método Dobrar " + y);
    }
} 