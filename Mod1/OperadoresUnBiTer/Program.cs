/*
 Operadores Uniários atuam em um operador em uma expressão:
    ++,--,!,+,- -> os dois ultimos é como polarização.


 Operadores binários atuam em dois operadores:
    &&, >=, =, * ,+, -

 Operador ternario utiliza 3 argumentos e avalia uma expressão boolean:
    ?:
    Formatação do ternário: condição ? expressão_true : expressão_false ( é executado uma das duas expressões se a condição for true or false;)
 
 */
Console.WriteLine("Operadores Multiplos");
Console.WriteLine();

Console.WriteLine("Informe a temperatura: ");
int temp = Convert.ToInt32(Console.ReadLine());

string resultado = temp > 27 ? "Quente" : "Normal";


Console.WriteLine($"O tempo está {resultado}");

Console.ReadKey();  