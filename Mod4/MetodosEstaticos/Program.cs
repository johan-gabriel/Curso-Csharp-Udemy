Console.WriteLine("## Modificador Static ##");
Console.WriteLine();

/*
 Os métodos com o modificador static não precisam de intanciamento de objetos para serem executados.
    Os métodos pertencem diretamente à class não ao objeto.

 
 */
Calculadora calc = new();
calc.Somar(2, 6);// necessita da intancia do obj, no caso calc, para ser chamado.
Calculadora.Divide(10, 2);// este é invocado direto da classe não pela instancia do obj.

A a1 = new();
a1.x = 1;

A.y = 2;

ContaCorrente c1 = new();
c1.Conta = 102;
c1.Nome = "Marta";
ContaCorrente.Juros = 3.99f;// Este é sobreposto pelo proximo!!!

ContaCorrente c2 = new();
c2.Conta = 101;
c2.Nome = "Maria";
ContaCorrente.Juros = 4.99f;// Pesiste o ultimo por conta de deixar a variável static.


Console.WriteLine($"Cliente: {c1.Nome} - Juros anual: {c1.JurosAnual()}");
Console.WriteLine($"Cliente: {c2.Nome} - Juros anual: {c2.JurosAnual()}");


Console.ReadKey();


public class Calculadora
{
    public int Somar(int num,int num2)
    {
        return num + num2;
    }
    public int Subtrair(int num,int num2)
    {
        return num - num2;
    }
    public int Multiplicar(int num,int num2)
    {
        return num * num2;
    }
    //Método static
    public static int Divide(int num,int num2)
    {
        return num / num2;
    }
}

public class A
{
    public int x;
    public static int y;


}

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}
//FIM

