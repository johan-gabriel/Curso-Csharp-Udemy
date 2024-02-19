Console.WriteLine("## Array ##");
int[] Numeros; // Como definir

string[] Nomes; // Como definir

Nomes = new string[2] { "Johan", "Kivia" };// Como alocar valores;

Numeros = new int[5] { 1, 2, 3, 4, 5 }; // Como alocar valores

Console.WriteLine($"indice 1:{Numeros[1]} - indice 3:{Numeros[3]} ");

Console.WriteLine($"{Nomes[0]}");

Numeros[1] = 22;

Console.WriteLine($"indice 1:{Numeros[1]} - indice 3:{Numeros[3]} ");

Console.WriteLine(" Acessando os elementos de um Array");

//For!!!
                 // tamanho da array;
for (int i = 0; i < Numeros.Length; i++)
{
    Console.WriteLine($"{Numeros[i]} - {i}");

}
Console.WriteLine();
//Foreach !!
/*
 A instrução foreach permite executar uma instrução ou um bloco de instruções para cada
elemento presenste em uma coleção( Array, List etc);
 */

foreach (int i in Numeros)
{
    Console.WriteLine(i); // acessa cada elemento dentro do array!!!
}



Console.ReadKey();