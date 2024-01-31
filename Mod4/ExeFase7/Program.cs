Console.WriteLine("Exercícios");
/*
 w- Substituir na classe Carro o campo Ano por uma propriedade de mesmo nome e mesmo tipo.

w1- Validar a informação do Ano de forma que se o ano informado for menor que 2000 seja atribuído 2000 e se
for informado maior que 2022 seja atribuído 2022 ao valor do ano.

w2- Explicar a diferença entre campo e propriedade.
R: Os atributos da classa como Campo são acessados diretamente pelo usuário, como propriedade os usuários t
 
 */

Console.ReadKey(); 

public class Carro
{
    private int ano;

    public int Ano
    {
        get { return ano; } 
        set 
        {
            if (ano < 2000) 
            {
                ano = 2000;
            }
            if (ano > 2024)
            {
                ano = 2024;
            }
        }

    }

}