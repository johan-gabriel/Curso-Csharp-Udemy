/*
 As vars de um tipo Valor ( Num, Char, Bool,Struct) sempre tem um valor associado, e são armazenada na memória stack;
 

Não é possível dar um valor Null a uma variavel de tipo valor. Da muito ruim!


Mas o Nullable Types podem receber valores null mesmo sendo do tipo valor.
Se declara da seguinte forma:
        Nullable<Tipo> Nome = null;
Veja no exemplo (1).

Pode ser declarado também como:
        Tipo? nome = null;
veja o exemplo (2);

Não é possível atribuir o valor do Nullable Type ao Não-NullableType! Pode contornar utilizando um operador: '??' - Operador de Coalescência Nula
Repare que o formato para contorno:
        int? a = null;
        int b = a ?? 0; se no caso de 'a' ser null o operador '??' converte null par a zero.
veja o exemplo (3);

Para efetuar funções matemáticas com nullable tipe é necessário nivelar todas as outras vars para o mesmo tipo.
ver o exemplo (4);
 */

Console.WriteLine("Nullable Types!!");
Console.WriteLine();

//int valor = null; //se descomentar essa linha vc verá o ERRO!

Nullable<bool> bolea = null; //################## (1) ######################
Nullable<int> inteiro = null;
Nullable<char> carac = null;

// Maneira simples

int? valor = null;//################# (2) #####################
double? flutu = null;
float? max = null;

// Anulando o Nullable Type
int? a = null;

int b = a ?? 0;

Console.WriteLine(b); // Imprime zero. ##################### (3) ######################
Console.WriteLine();

// Nivelando ################# (4) #################
int? x = 2;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);
Console.WriteLine();

// Utilizando verificadores de NullableType

int? Carro = null;

if (Carro.HasValue)
{
    Console.WriteLine($"b = {Carro.Value}"); // Concatena string a valores fixos ou vars
}                           //Value para saber o estado perguntado acioma no IF.
else
{
    Console.WriteLine($"b = não possui valor");// Nunca colocar uma situação similar ao de cima pois da um erro no programa.
}                            