Console.WriteLine("Parametros opcionais");
Console.WriteLine();

Email email = new();
// maneira de nomear a argumentação colocada em métodos e classes. a ordem não tem importancia
email.Enviar(destino: "jmonsterx597@gmail.com", assunto: "Um jogo em sua biblioteca de desejados está com 50% de desconto");



Console.ReadKey();

public class Email
{
    //Deixando o valor inicial de um argumento, você transforma ele opcional.
    //Se for criar um tem que ser depois dos parâmetros obrigatórios.
    public void Enviar(string destino, string titulo = "Reunião", string assunto = "Urgente")
    {
        Console.WriteLine($"\n Para {destino} - {titulo} \n Assunto: {assunto}");
    }
}
