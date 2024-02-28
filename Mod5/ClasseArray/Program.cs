/*

    Class Array: 
        Fornece métodos para criar, manipular, pesquisar e classificar arrays, servindo assim
    como a classe base para os arrays;
        *Reverse: Só para lineares;
        *Sort
        *BinarySearch - Se retornar um valor int > 0 foi encontrado
                        Se retornar um valor int < 0 não foi encontrado



 */
using System.Runtime.CompilerServices;

Console.WriteLine(" ## Reverse ## ");

int[] valores = new int[10] { 5, 4,9,3,1,0,6,7,8,2};

Console.WriteLine("\n\n Array Original");
ExibeArray(valores);

Array.Reverse(valores);// Reverse - Inverte a sequência
Console.WriteLine("\n\n Array Invertido - Reverse");
ExibeArray(valores);


Console.WriteLine("\n\n Array Ordenado - Sort");
Array.Sort(valores);
ExibeArray(valores);

Console.WriteLine("\n\n Array Buscador - BrinarySearch");
Console.WriteLine("\n Informe um valor");
int num = Convert.ToInt32(Console.ReadLine());

var indice = Array.BinarySearch(valores, num);

if(indice >= 0)
{
    Console.WriteLine($"\n {num} foi encontrado com indice = {indice}");
}
else
{
    Console.WriteLine($"\n {num} Não foi encontrado");
}

Console.ReadKey();

static void ExibeArray(int[] valores)
{
    foreach (int val in valores)
    {
        Console.Write($" {val} ");
    }
}