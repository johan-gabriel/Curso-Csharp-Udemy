using System.Collections;
using System.Security;
/*
   ArrayList não tem um tipo específico, pode ser alocado qualquer tipo de valor dentro
  do limite da array;

    O Método Add permite incluir um único elemento ao final de uma ArrayList
    O Método Insert(int index, Object value) Permite incluir um elemento em uma 
posição qualquer usando um índice específico 
 */
Console.WriteLine("## ArrayList ##");
int[] array1 = {1,2,3};
//Primeira maneira 
ArrayList Lista;
Lista = new ArrayList();

//Segunda

var Lista4 = new ArrayList() { "ANA",5, true," ",null,1.1,"Zé", 3,9,0 };// aqui limitando a capacidade

//Terceira
ArrayList Lista3 = new() { "Maria", 5, true};

// adicionando elementos
//Método Convencional usando ADD
Lista.Add("Paulo");
Lista.Add(4.5);
Lista.Add(5);
Lista.Add(true);
Lista.Add(null);

Lista.Insert(2, "Johan"); // Adiciona o valor e 'empurra' os outros valores;

//Método resumido

ArrayList Lista2 = new ArrayList()
{
    "Zezé", 4.89, 9,false,'c'
};

// adicionando coleções!
Lista3.AddRange(array1); // add ao final

Lista3.InsertRange(2, array1);

//Remover valores
Lista4.Remove(null); // remove o valor correspondente ao que está nos parenteses.

Lista4.RemoveAt(7); // remove o valor do indice correspondente;em parenteses é o valor
                    // do indice

Lista4.RemoveRange(0, 2);// Remove os elementos especificados a partir do primeiro valor que
                         // é o indece, e o segundo é a quantidade de valores; contando com o
                         // valor nesse indice



// Verificar se um elemento esta na coleção

//contains
bool verifc = Lista.Contains(5);
bool verifc2 = Lista.Contains(9.8);

Console.WriteLine($"{Convert.ToString(verifc)} - {Convert.ToString(verifc2)}");

//quickSort serve para ordenar a Arraylist de forma ascendente para valores iguais

var ListaOrg = new ArrayList() { "X", "Iron-Man", "Spider", "Hulk", "Batman" };
for(int i = 0;i<ListaOrg.Count;i++)
    Console.WriteLine($"Não alterado:{ListaOrg[i]}\n");

ListaOrg.Sort();

Console.WriteLine();
for (int i = 0; i < ListaOrg.Count; i++)
    Console.WriteLine($"Alterado:{ListaOrg[i]}\n");

Console.ReadKey();
