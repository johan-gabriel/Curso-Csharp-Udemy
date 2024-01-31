Console.WriteLine("Exercícios");
/*
 x- Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para
todos os carros

y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva

z- Acesse o valor do campo ValorIpva e exiba no console. Explique o comportamento da palavra-chave static.
 
 */
Carro.ObterValorIPVA();
Console.WriteLine(Carro.ValorIpva);

Console.ReadKey(); 

public class Carro
{
    public static double ValorIpva;

    public static void ObterValorIPVA()
    {
        ValorIpva = 4.00;
    }
}