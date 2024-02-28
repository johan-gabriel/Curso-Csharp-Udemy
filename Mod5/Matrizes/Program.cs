Console.WriteLine(" ## Matizes ##");
/*
 pode ser declarado como indefinido:
    var[,]
pode ser declarado como definido:
    var[i,j] sendo o i o indice das linhas e j como colunas;


    OBS:
        ao executar os fors é necessário utilizar o GetLength(indice da dimensão) 
        para não apresenstaruma excessão.
 
 */
int[,] array2d = new int[3,3] { 
    { 1, 2, 5 },
    { 2, 5, 3 },
    { 9, 4, 3 } 
};
                    // dimensão 0
for (int i = 0; i < array2d.GetLength(0); i++)
{
    Console.WriteLine();
                        // dimensão 1
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        Console.Write(Convert.ToString($"{array2d[i, j]} - [{i},{j}]"));
    }
}



Console.ReadKey();
