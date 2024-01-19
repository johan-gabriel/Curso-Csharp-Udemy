Console.WriteLine("Exercícios 2");
Console.WriteLine();
//_______________________________________________________________________________________________________________________
// 1)
string nome = "Paulo";
int idade = 17;
float nota = 7.5f;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota final {nota}");
Console.WriteLine();
//_______________________________________________________________________________________________________________________
// 2)

Console.WriteLine($"Aluno {nome}\n Tem {idade} anos\n nota final {nota}");
Console.WriteLine();
//_______________________________________________________________________________________________________________________
// 3)
/*
 |F|
 |V|
 |V|
 |V|
 */
//_______________________________________________________________________________________________________________________
// 4)
/*
 |F|
 |V|
 |V|
 |V|
 |V|
 |F|
 
 */
//_______________________________________________________________________________________________________________________
// 5)
/*char let1, let2,let3;

Console.WriteLine("Diga as letras que você quer:");
Console.WriteLine("Primeira Letra: ");
let1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Segunda Letra: ");
let2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Terceira Letra: ");
let3 = Convert.ToChar(Console.ReadLine());

Console.WriteLine("A terceira é \'" + let3 + "\' segunda é \'" + let2 + "\' primeira é \'" + let1 + "\'");
Console.WriteLine();*/
//_______________________________________________________________________________________________________________________
// 6)
/*
 |F|
 |V|
 |V|
 |V|
 |F|
 |V|
 |F|
 |V|
 |F|
 |F|
 */
//_______________________________________________________________________________________________________________________
// 7)
/*double valor1, valor2, resultado;
string var1, var2;
Console.WriteLine("Diga qual é o primeiro numero com a vigula: ");
var1 = Console.ReadLine();
Console.WriteLine("Diga qual é o segundo número com a vigula: ");
var2 = Console.ReadLine();

valor1 = Convert.ToDouble(var1);
valor2 = Convert.ToDouble(var2);

Console.WriteLine(valor1);
Console.WriteLine(valor2);


resultado = valor1 + valor2;
Console.WriteLine("Soma: " + resultado);
Console.WriteLine();

resultado = valor1 - valor2;
Console.WriteLine("Subtração: " + resultado);
Console.WriteLine();

resultado = valor1 * valor2;
Console.WriteLine("Multiplicação: " + resultado);
Console.WriteLine();

resultado = valor1 + valor2;
Console.WriteLine("Exponêncial da soma: " + Math.Exp(resultado));
Console.WriteLine();

resultado = valor1 / valor2;
Console.WriteLine("Divisão: " + resultado);
Console.WriteLine();

resultado = valor1 % valor2;
Console.WriteLine("Módulo: " + resultado);
Console.WriteLine();
//_______________________________________________________________________________________________________________________
// 8)
Console.WriteLine("Formula de Baskara!");
int a = 1, b = 12, c = -13;
double x1, x2;
Console.WriteLine($"Equação dada por: {a}x² + {b}x + {c}");
Console.WriteLine();
Console.WriteLine("Calculando x1 e x2 da equação...");
Console.WriteLine();
x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))/(2*a);
x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

Console.WriteLine($"X1 é: {x1}");    
Console.WriteLine($"X2 é: {x2}");*/
//_______________________________________________________________________________________________________________________
// 9)
Console.WriteLine("Login e senha: ");
string nomeLogin = Console.ReadLine();
Console.WriteLine();
int senha = Convert.ToInt32(Console.ReadLine());
string mensagem;
Console.WriteLine();
Console.WriteLine("Verificação.....");

mensagem = nomeLogin == "admin" && senha == 123 ? "Login feito com sucesso!" :
    nomeLogin == "maria" && senha == 123 ? Convert.ToString(2+2) : "Login Invalido";

Console.WriteLine(mensagem);


Console.ReadKey();