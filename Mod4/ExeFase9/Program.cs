using ExeFase9;
Console.WriteLine("Exercícios");
/*
 - Crie uma enumeração chamada Cores em um arquivo CarroEnum.cs que defina os seguintes membros :
Branco, Vermelho, Preto, Cinza, Prata e Azul

- Inicie o valor da enumeração com 1

- Inclua na classe Carro o campo Cor do tipo int que vai representar a cor do carro

- Altere o construtor da classe incluindo o campo Cor para criar objetos usando a Cor selecionada

- Defina um menu de opções exibindo o nome da Cor e o seu valor

- Receba a seleção do usuário em uma variável do tipo int cor que vai ser usada para atribuir ao campo Cor

- Altere o método ExibirInfo() incluindo o parâmetro cor do tipo int como parâmetro opcional e exiba o nome da
cor a partir do valor da Cor recebida
 
 */

Console.WriteLine("Digite o numero da cor que é desejada");
                                    // Exibe o valor da cor
Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");
int CarCor = Convert.ToInt32(Console.ReadLine());




Carro carro = new(CarCor);
carro.ExibirInfo();



Console.ReadKey();


