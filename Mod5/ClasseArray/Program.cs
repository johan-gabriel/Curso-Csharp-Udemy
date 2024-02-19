/*

    Class Array: 
        Fornece métodos para criar, manipular, pesquisar e classificar arrays, servindo assim
    como a classe base para os arrays;
        *Reverse: Só para lineares;



 */
Console.WriteLine(" ## Reverse ## ");

int[] valores = new int[10] {0,1,2,3,4,5,6,7,8,9};

foreach (int val in valores)
{
    Console.WriteLine(val);
}

Array.Reverse(valores);// Reverse - Inverte a sequência

foreach (int val in valores)
{
    Console.WriteLine(val);
}



Array.Sort(valores);






Console.ReadKey();
