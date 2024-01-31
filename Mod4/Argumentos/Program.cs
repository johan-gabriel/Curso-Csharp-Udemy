using System.Reflection;

Console.WriteLine("Nomeando Argumentos");
Console.WriteLine();

Email email = new();
// maneira de nomear a argumentação colocada em métodos e classes. a ordem não tem importancia
email.Enviar(destino:"jmonsterx597@gmail.com",titulo: "Jogo com desconto",assunto:"Um jogo em sua biblioteca de desejados está com 50% de desconto");



Console.ReadKey();

public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}
