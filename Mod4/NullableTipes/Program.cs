/*
 Nullable Types:
    É um tipo de valor que pode receber Null mesmo, o tipo do variável sem ser não nullable,
    
 
 */

Console.WriteLine("Nullables!");
Console.WriteLine();

Nullable<int> i = null;
Nullable<double> d = null;
Nullable<bool> b = null;

int? a = null; // outra maneira de transformar em anulavel
int? c = null;
int? v = null;
int x = a ?? 0;

Console.WriteLine(x);

if(b.HasValue) 
{
    Console.WriteLine($"b = {b.Value}");
}
else
{
    Console.WriteLine("b não possui um valor");
}

Console.ReadKey();
