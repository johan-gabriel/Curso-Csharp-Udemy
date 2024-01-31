using System.ComponentModel.Design;
using Enums;

Console.WriteLine("## ENUM ##");
/*
 É uma classe que enumerada!!;
 */
int sabado = (int)DiasDaSemana.sabado;

Console.WriteLine(DiasDaSemana.sabado + " " + sabado);
Console.WriteLine(DiasDaSemana.segunda);


Console.WriteLine($"{Menu.Moda} - {(int)Menu.Moda}");
Console.WriteLine($"{Menu.AutoPecas} - {(int)Menu.AutoPecas}");
Console.WriteLine($"{Menu.Artes} - {(int)Menu.Artes}");
Console.WriteLine($"{Menu.Bebidas} - {(int)Menu.Bebidas}");
Console.WriteLine($"{Menu.Livros} - {(int)Menu.Livros}");
Console.WriteLine($"{Menu.Brinquedos} - {(int)Menu.Brinquedos}");
Console.WriteLine();
Console.WriteLine("Selecione uma das opções do menu");
int valor = Convert.ToInt32(Console.ReadLine());
                // quest para tranformar no valor que está no enum
var nomeEmMenu = (Menu)valor;
Console.WriteLine($"{nomeEmMenu} = {valor}");




Console.ReadKey();
 