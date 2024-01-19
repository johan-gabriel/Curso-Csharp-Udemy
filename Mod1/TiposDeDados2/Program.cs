Console.WriteLine("Atribuindo valores à flutuantes");
Console.WriteLine();


double n1 = 1.23512; // double não necessíta de sufixo!
float n2 = 2.523f;   // Float necessíta de sufixo f ou F!
decimal n3 = 5.312452345m; //Decimal necessíta de sufixo m ou M! Maior precisão dos flutuantes.

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.ReadLine();

Console.WriteLine("Comparando a precisão de cada um:");

float x = 1f / 3f; // A barra "/" serve como operador de divisão;
double y = 1d / 3d;
decimal z = 1m / 3m;
// aqui vou demonstrar o quanto preciso é cada um dos pontos flutuantes;
Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);
Console.ReadLine();
