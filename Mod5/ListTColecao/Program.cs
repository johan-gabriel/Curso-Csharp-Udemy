using System.Collections.Generic;
Console.WriteLine("## LIST <T> ##");
//Tipo: Pode ser qualquer tipo e até mesmo classe!
string[] Array1 = { "Teco", "Teco", "Bico" };
List<string> list = new List<string>()
// Tem a quantidade (Count) e a Capacidade max que vai
// de 4 em 4 (capacity)
                        {
                            "Paulo", "Maria", "Bia", "Pedro"
                        };

list.Add("Cachorrão");
list.Insert(2, "Batman");// insere um elemento na lista na posição avisada....
list.InsertRange(3, Array1); // Insere mais de um elemento a apratir da posição avisada...
//list.Remove("Teco");// remove o elemento ou os com o mesmo valor
//list.RemoveAt(5);// remove o elemento pelo índice
//list.RemoveRange(1, 2);// Remove os elementos apartir do priemiro valor, na qauntidade do segundo


// Boxing: É a conversão de um Value Type para um Reference Type

int num = 23;
Object obj = num;// Boxing
int i = (int)obj;// Unboxing

//Find predicado como função
var Encontrar = list.Find(Procura);
Console.WriteLine(Encontrar);

//Find com predicado expressão lambda
var frutas = list.Find(i => i.Contains('n'));//a expressão lambda puxa o valor da variável?....

Console.WriteLine(frutas);

Console.ReadKey();

static bool Procura(string str)
{
    return str.Contains('n');

}