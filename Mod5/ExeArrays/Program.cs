Console.WriteLine(" ## Exercícios Array ##");

Console.WriteLine();

/*
 Crie um programa C# que receba via teclado o nome de cinco alunos e armazene os em 
um array chamado nomes.
 
 */
string[] nomes = new string[5];
double[] nota = new double[5];
double media = 0;
Console.WriteLine("Informe os nomes dos alunos e a nota de cada um.");
for (int i = 0; i < 5; i++)
{
    Console.Write("Nome:");
    nomes[i] = Console.ReadLine();
    Console.Write("Nota:");
    nota[i] = Convert.ToDouble(Console.ReadLine()); 
}

ExibeArray(nomes, nota);

for(int i = 0;i < 5; i++)
{
    media = media + nota[i];
}

Console.WriteLine($"\nMedia: {media / nota.Length}");

Console.ReadKey();

static void ExibeArray(object[] array, double[] array2)
{
    for (int i = 0;i < array.Length; i++)
    {
        Console.Write($"\n {array[i]} = {array2[i]}");
    }
}