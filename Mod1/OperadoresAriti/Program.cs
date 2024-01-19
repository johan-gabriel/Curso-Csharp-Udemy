/*
+ -> Serve para somar

- -> Serve para Subtrair
* -> Serve para Multiplicar

/ -> Serve para dividir

% -> Retorna o resto da divisão entre dois numeros.

Classe Math!

Math.PI -> Representa o numero PI
Math.E -> Representa a constante de Euler

Cos(x)
Sen(x)
Tan(x)
Sqrt(x) -> raiz quadrada
Pow(x,y) -> potencia de x elevado a y
Abs(x) -> Obtem o valor absoluto
Max(x,y) -> Obtem o maior valor entre x e y
Min(x,y) -> Obtem o menor vlaor entre x e y
Log10(x)
Log(x) -> Obtem o logaritimo natural de x
Exp(x) -> Retorna o exponencial de Euler elevado a x

 
 */

Console.WriteLine("Operadores Aritiméticos!");
Console.WriteLine("Informe o valor atual de X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O valor de x é: " + x);
Console.WriteLine("\nInforme o valor atual de Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("O valor de y é: " + y);

Console.WriteLine("Soma de x+y = " + (x + y));
Console.WriteLine("Subitração de x-y = " + (x-y));
Console.WriteLine("Multiplicação de x*y = " + (x * y));
double divisao = (double)x / (double)y;
Console.WriteLine($"Divisão de x/y = {divisao}");
Console.WriteLine("Módulo de x%y = " + (x % y));


Console.WriteLine();

Console.WriteLine("Classe Math");           // quando for chamar uma classe sempre antes do método como a console...
Console.WriteLine("Raiz quadrada de x = " + Math.Sqrt(x));
Console.WriteLine("Potencia de x^y = " + Math.Pow(x,y));
Console.WriteLine("Log base 10 de x = " + Math.Log10(x));
Console.WriteLine("Log base e de x = " + Math.Log(x));
Console.WriteLine("Euler^x = " + Math.Exp(x));
Console.WriteLine("Valor mais alto entre x e y = " + Math.Max(x,y));
Console.WriteLine("Valor mais baixo entre x e y = " + Math.Min(x,y));





Console.ReadKey();
