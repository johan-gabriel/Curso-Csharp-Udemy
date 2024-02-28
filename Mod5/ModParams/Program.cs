Console.WriteLine("## Params ##");
int[] valores = { 1, 2, 3 };

var resultado = Calcular.Soma(valores);
Console.WriteLine(resultado);

var res2 = Calcular.Soma(1, 2, 3, 4, 5, 6, 7, 8, 9); // params possibilita isso;

Console.ReadKey();

public class Calcular
{
    public static int Soma(params int[] numeros) // pode ser utilizado uma vez e tem que ser
                                                 // o ultimo
    {
        int total = 0;
        foreach (int i in numeros)
        {
            total += i;

        }
        return total;
    }

}