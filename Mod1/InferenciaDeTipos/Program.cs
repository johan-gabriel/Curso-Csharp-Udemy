/*
Linguagem Tipada ou seja para você utilizar  uma declaração em C# é necessário antes identificar o tipo de declaração....
Tipo implicito var, é utilizado para fazer o compilador deduzir o tipo explicito da variavel:
    tipo interno;
    tipo anônimo;
    tipo definido pelo usuário;
    tipo definido na biblioteca;
// Limitações !!!
Não se pode declarar uma var sem atribuir um valor. O compilador irá reclamar que a var deve ser inicializada com um valor.
Não se pode inicializar a var com valor NULL.
Multiplas varáveis de tipo implícito não podem ser inicializadas na mesma instrução.
Não é possível mudar o tipo depois de inicializar com um tipo.
 
 */
Console.WriteLine("Hello, World!");
int valor = 0;// Declaração explicita: Deixa evidente o tipo que a variável irá carregar.
var valor1 = 2;// Declaração indireta ou implicita: Deixa que o compilador perceba qual é o tipo de dado que está senod atribuido.

int idade = 26;
string nome = "Johan";
decimal salario = 3100.00m;
                                                            // transfere o valor para a moéda local.
Console.WriteLine($"{nome} tem {idade} anos e ganha {salario.ToString("c")}");

var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();
// aplicação
class Teste
{
    public void MeuMetodo()
    {
        Console.WriteLine("Meu Método!");
    }
}