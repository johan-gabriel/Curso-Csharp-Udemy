/*
 São maneiras de comparar 2 ou mais variáveis....
    == -> Igualdade
    >  -> Maior que
    <  -> Menor que
    >= -> Maior igual
    <= -> Menor igual
    != -> Diferente

Para comparação de igualdade pode ser utilizado o Método de Equals()

 */
Console.WriteLine("Operadores Relacionais");

int x = 10;
int y = 20;

Console.WriteLine("Igualdade!");
Console.WriteLine($"x({x}) == y({y})? {x == y}");
Console.WriteLine();

Console.WriteLine("Maior que!");
Console.WriteLine($"x({x}) > y({y})? {x > y}");
Console.WriteLine();

Console.WriteLine("Menor que!");
Console.WriteLine($"x({x}) < y({y})? {x < y}");
Console.WriteLine();

Console.WriteLine("Maior Igual!");
Console.WriteLine($"x({x}) >= y({y})? {x >= y}");
Console.WriteLine();

Console.WriteLine("Menor Igual!");
Console.WriteLine($"x({x}) <= y({y})? {x <= y}");
Console.WriteLine();

Console.WriteLine("Diferente!");
Console.WriteLine($"x({x}) != y({y})? {x != y}");
Console.WriteLine();