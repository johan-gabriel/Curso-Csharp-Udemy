//Console.WriteLine("EX1");
//Console.WriteLine();
//int cont = 0;
//string[] frutas = new string[10] {"Maça","Banana","Laranja","Uva","Manga","Pêra", "Abacate","Mamão", "Pêssego", "Amora" };

//Console.WriteLine("a");
//foreach (string frut in frutas)
//{
//    cont++;

//    Console.WriteLine($"{frut} - {cont}");

//}

//Console.WriteLine("\nb\n");
//Console.WriteLine($"{frutas[1]} da posição 2 e {frutas[8]} da posição 9\n");


//Console.WriteLine("c\n");

//frutas[2] = "Kiwi";
//frutas[9] = "Caqui";
//cont = 0;
//foreach (string frut in frutas)
//{
//    cont++;

//    Console.WriteLine($"{frut} - {cont}");

//}
//Console.WriteLine("\nd\n");
//Array.Sort(frutas); 
//cont = 0;
//foreach (string frut in frutas)
//{
//    cont++;

//    Console.WriteLine($"{frut} - {cont}");
//}

//Console.WriteLine("\ne\n");
//Array.Reverse(frutas);
//cont = 0;
//foreach (string frut in frutas)
//{
//    cont++;

//    Console.WriteLine($"{frut} - {cont}");
//}


//Console.WriteLine("EX2");
//Console.WriteLine();
//string finalizador = "";
//bool aciona = true;

//while (aciona) {
//    Console.WriteLine("Digite quantos elementos o array terá:");
//    int indice = Convert.ToInt32(Console.ReadLine());
//    int valorP = 0;

//    int[] inteiros;
//    inteiros = new int[indice];

//    Console.WriteLine($"Array de tamanho {indice}\n");
//    Console.WriteLine("Preencha o Array:");
//    for (int i = 0; i < inteiros.Length; i++)
//    {
//        Console.WriteLine($"Numero da posição {i}");
//        inteiros[i] = Convert.ToInt32(Console.ReadLine());
//    }
//    Console.WriteLine($"\n Pesquisa de Dados da Array:");
//    var valorINt = Convert.ToInt32(Console.ReadLine());
//    var resposta = Array.BinarySearch(inteiros, valorINt);

//    if (resposta <= -1)
//    {
//        Console.WriteLine("Valor não existe no Array!");

//    }
//    else
//    {
//        Console.WriteLine($"Valor existe na posição {resposta} ");
//    }

//    Console.WriteLine("Deseja finalizar? Se sim digite (fim)");
//    finalizador = Console.ReadLine();

//    if (finalizador == "fim")
//    {
//        aciona = false;
//    }
//}

using Exercicios;

//Console.WriteLine("Exe 3");
//Console.WriteLine();

//DadosAlunos dados = new DadosAlunos();

//dados.SetValores();
//dados.GetValores();



Console.ReadKey();