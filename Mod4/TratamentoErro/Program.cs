Console.WriteLine(" ## Tratar Erros ## ");






Console.WriteLine("x / y");
Console.WriteLine("\n Informe o valor de x:");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n Informe o valor de y:");
int y = Convert.ToInt32(Console.ReadLine());




try // primeiro tenta este
{
    int z = x / y;
    Console.WriteLine($"\n {x} / {y} = {z}");
}
catch (Exception ex)// se não deu certo vem pra este.
{
    Console.WriteLine("Não existe divisão por zero tente outro numero");
    Console.WriteLine($"\nErro: <<< {ex.Message} >>>"); // qual é o erro de excessão 
    Console.WriteLine($"\nDetalhes {ex?.StackTrace?.ToString()}");// mostra qual linha ocorreu o erro
}
finally // opcional
{
    Console.WriteLine("Execução finalizada!");
}

Console.ReadKey();