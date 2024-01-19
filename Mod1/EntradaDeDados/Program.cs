/*
Console.ReadLine():
    Lê uma única linha de entrada do fluxo de entrada padrão.
        Retorna a mesma string da entrada.

ConsoleRead():
    Lê apena um único caractere do teclado ( fluxo de entrada padrão)
        Retorna o valor ASCII do caractere.

ConsoleReadKey():
    Lê apenas um único caractere do fluxo de entrada padrão.
        Obtém a próxima tecla pressionada pelo usuário.
        Retorna um tipo de ConsoleKeyInfo.
        É usado para segurar a tela até que o usuário pressione uma tecla.
 
 
 */
Console.WriteLine("Entrada de Dados!");



Console.WriteLine("\nInforme o seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("\nInforme a sua idade: ");
string idadeS = Console.ReadLine();
int idadeI = Convert.ToInt32(idadeS);

Console.WriteLine("O seu nome é: " + nome + "?");
Console.WriteLine("E sua idade é: " + idadeI + "?");


Console.ReadKey();