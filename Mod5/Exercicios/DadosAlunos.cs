using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class DadosAlunos
    {
       public string[,] alunos = new string[4,5];

        public void SetValores()
        {
            alunos[0, 0] = "Aluno1";
            alunos[0, 1] = "Aluno2";
            alunos[0, 2] = "Aluno3";
            alunos[0, 3] = "Aluno4";
            alunos[0, 4] = "Aluno5";
            alunos[2, 0] = "Aluno6";
            alunos[2, 1] = "Aluno7";
            alunos[2, 2] = "Aluno8";
            alunos[2, 3] = "Aluno9";
            alunos[2, 4] = "Aluno10";


            for (int i = 1; i < alunos.GetLength(0); i++)
            { 
                if (i == 2)
                {
                    i++;
                }
            
                for(int j = 0; j < alunos.GetLength(1); j++)
                {
                    
                    
                        Console.WriteLine($"Digite a nota do aluno {alunos[i-1, j]} :");
                        alunos[i,j] = Console.ReadLine();
                    
                }
            }
        }

        public void GetValores()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    
                    switch (i)
                    {
                        case 0:
                            Console.Write($" {alunos[i, j]} ");
                            break;
                        case 1:
                            Console.Write($"   {alunos[i, j]}    ");
                            break;
                        case 2: 
                            Console.Write($" {alunos[i, j]} ");
                            break ;
                        case 3:
                            Console.Write($"   {alunos[i, j]}    ");
                            break;
                    } 
                }
                Console.WriteLine();
            }
        }

    }
}
