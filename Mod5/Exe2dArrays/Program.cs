Console.WriteLine("## Exercícios de Arrays 2d ##");

string[,] alunos = new string[2, 5] {
    {"Maria", "Paulo","Marta","Pedro","Carlos" },
    {"Silvia","Amanda", "Manoel","Paula","Alicia" }
};

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0;j < alunos.GetLength(1); j++)
    {
        Console.Write($"{alunos[i, j]} - [{i},{j}]");
    }
    Console.WriteLine();
}


Console.ReadKey();

