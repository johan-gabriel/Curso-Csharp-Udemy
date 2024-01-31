Console.WriteLine("Exe. 1 e 2");
Console.WriteLine();
/*
 - Crie um método AumentarPotenciaVelocidade que recebe o parâmetro int potencia e retorna um int
como valor da nova potência. Neste método use parâmetro out e passe a variável velocidade e que vai
retornar a nova velocidade como um double.
(incremente a potência de 7 e calcule a nova velocidade multiplicando a potência por 1.75)
 
Faça a chamada ao método exibindo os valores da nova potencia e da nova velocidade e explique o
comportamento do parâmetro out.
 */

Console.WriteLine("Informe a potência do veiculo: ");
int potencia = Convert.ToInt32(Console.ReadLine());

Potenciometro potenciometro = new();

int pow =potenciometro.AumentPotVel(potencia, out double velocidade);

Console.WriteLine("Potência: " + pow);
Console.WriteLine();  
Console.WriteLine("Velocidade max: " + velocidade);




public class Potenciometro
{
    public int AumentPotVel(int potencia,out double velocidade)
    {
        velocidade = potencia * 1.75;
        potencia += 7;
        return potencia;
    }

}