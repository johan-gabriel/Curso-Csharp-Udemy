/*
Operadores de incremento e decremento server para adicionar +1 ou subtrair -1.

++ -> incrementeta em +1 uma variável.
-- -> decrementa em -1 uma variável.

Pós-incremento/decremento ( x++/--) : Neste caso é feito o incremento depois da variável ser usada.
Pré-incremento/decremento ( ++/--x) : Neste caso é feito o incremento antes da variável ser usada.
 
 
 */
Console.WriteLine("Incremento e Decremento!");

var numero = 10;
    int resultado, resultado2;
// caso de Pré-Incremento/Decremento
Console.WriteLine("Valor inicial do numero: " + numero);
Console.WriteLine();

numero++;

Console.WriteLine("Valor do numero incrementado com ++: " + numero);
Console.WriteLine();

numero--;
Console.WriteLine("Valor do numero incrementado com --: " + numero);
Console.WriteLine();
resultado = numero++ + 5;

Console.WriteLine("pós-incremneto = "+ resultado);
Console.WriteLine("Agora Numero = " + numero);

Console.WriteLine();
resultado = ++numero + 5;

Console.WriteLine("pré-incremneto = " + resultado);
Console.WriteLine("Agora Numero = " + numero);

Console.ReadKey();
