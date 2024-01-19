/*
 Operadores de Atribuição:
    = -> a var a esquerda recebe o valor a direita.
    += -> a var a esquerda recebe a soma do valor a direita. ( Unico que é compatível com String)
    -= -> a var a esquerda recebe a subtração do valor a direita.
    *= -> a var a esquerda recebe a multiplicação do valor a direita.
    /= -> a var a esquerda recebe a divisão do valor a direita.
    %= -> a var a esquerda recebe a sobra da divisão pelo valro a direita.
 
 */
Console.WriteLine("Operadores De Atribuição.");
Console.WriteLine();

int x, y, soma = 0;
string valor = "123";

Console.WriteLine("Declare o valor de x: ");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Declare o valor de y: ");
y = Convert.ToInt32(Console.ReadLine());

soma += x;

Console.WriteLine(soma);
Console.WriteLine();

soma -= y;

Console.WriteLine(soma);
Console.WriteLine();

soma *= x;

Console.WriteLine(soma);
Console.WriteLine();

soma %= y;
Console.WriteLine(soma);
Console.WriteLine();

Console.WriteLine(valor);
valor += "45677777";
Console.WriteLine(" No caso de Strings!!!!");
Console.WriteLine(valor);

Console.ReadKey();