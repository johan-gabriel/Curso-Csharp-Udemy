Console.WriteLine("Exe. 1");
Console.WriteLine();
/*
 - Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado
    potencia e retorna um int representando o aumento de potencia.
    (para aumentar a potência incremente 3 ao parâmetro recebido
 */

Calculador calc = new();


int pot = 50;


Console.WriteLine(calc.AumentaPotencia(pot));
Console.WriteLine();

Console.WriteLine("Exe. 2");
Console.WriteLine();
/*
 - Invocar o método criado e passar o valor do argumento por valor e exibir os valores. Explique o
comportamento da passagem do argumento por valor

R: Como o valor está sendo enviado para ser tratado mas só a cópia dele, o valor final não é alterado.

 */
Calculador calc1 = new();


int pot1 = 50;
int pot2 = 42;

Console.WriteLine("\n Valor do pot1 antes: " + pot1);
Console.WriteLine(calc1.AumentaPotencia(pot1));
Console.WriteLine("\n Valor do pot1 Depois: " + pot1);
Console.WriteLine();

Console.WriteLine("Exe. 3 e 4");
Console.WriteLine();
/*
 3 - Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro do tipo int por referência
chamado potencia e retorna um int representando o aumento de potencia.
(para aumentar a potência incremente 5 ao parâmetro recebido)

 4 - Invocar o método e passar o valor do argumento por referência e exibir os valores. Explique o
comportamento da passagem do argumento por referência.

 */
Console.WriteLine("\n Valor do pot2 antes: " + pot2);
calc1.AumentaPotencia(ref pot2);
Console.WriteLine("\n Valor do pot2 Depois: " + pot2);
Console.WriteLine();



Console.ReadKey();

public class Calculador
{
    public int AumentaPotencia( int potencia)
    {
        potencia += 3;
        return potencia;
    }
    public int AumentaPotencia(ref int potencia) // sobrecarga de método
    {
        potencia += 5;
        return potencia;
    }
}