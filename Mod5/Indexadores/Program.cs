Console.WriteLine(" ## Indexadores ##");
/*
    
    Os Indexadores permitem que as instâncias de uma classe ou struct sejam indexadas como um array.
    Eles lembram as propriedades mas seus assesores(get,set) recebem parâmetros.
    
    Um indexador é um membro da classe que permite acessar uma variável de membro da classe ou struct usando os de um array.
    
    Quando você define um indexador para uma classe, essa classe se comporta como um array virtual e podemos acessar a instâcia da classe usando o
operador de acesso ao array([]) e também usar índices para acessar e atribuir valores como nos arrays.

 */

Time time = new();

// Get do indexador
time[1] = "Curintia";
time[2] = "Sum paulo";
time[3] = "Sants"; //  estou indexando valores para o atributo da minha classe sem acessálo diretamente...
time[1000] = "Bluebluba";

//Set do indexador
string valor1 = time[1];
string valor2 = time[2];
string valor3 = time[3];
string valor4 = time[1000];


Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);
Console.WriteLine(valor4);


Console.ReadKey();

public class Time
{
    string[] valor = new string[10];

    public string this[int i]
    {
        get
        {
            if(i >= 0 && i < valor.Length) // se o indexador for maior/igual a zero e menor do que o tamanho da array valor.
            {
                return valor[i]; // obetem o valor do i e o valor em i momento...
            }
            return "Erro";
        }
        set
        {
            if(i >= 0 && i < valor.Length)
            {
                valor[i] = value; // atribui o value para o valor na posição corespondente...
            }
        }
    }
}