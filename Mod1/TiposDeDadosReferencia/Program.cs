Console.WriteLine("Declarando String, Object, Dynamic");
Console.WriteLine();

string palavra = "Curso"; // utilizando o ALIAS par a string
String titulo = "Curso C# Essencial";// utilizando o Tipo .NET para declarar uma string também.

Console.WriteLine(palavra + titulo);

/*
 As strings são imultaveis: uma vez declarada uma var do tipo STRING ela não pode ser alterada.

No caso abaixo as 3 atribuições a string NOME estão gerando um novo espaço em memoria par apoder trocar 
o valor obtido na declaração. Isso ocupa mais epaço em memoria e depois de executado o programa o limpador tera um trabalhão
para limpar tantos espaços realocados.
 */

string nome = "Isto é uma string inalterada";

nome = "Houve uma alteração!";

nome = "De novo pra ficar esperto";

/*
 O Object é um tipo que pode ser qualquer tipo kkkk. Ou seja um coringa que se for necessário trocado o seu valor por outro tipo de var ele 
aceita a alteração numa boa.

O Dynamic é bem parecido com o Object, mas é utilizado mais em aplicações de refrection ou linguagens dinamicas DLR
 */
object nota = 10;
object decima = 8.55;
object aula = "Johan";
object ativa = true;
dynamic letra = 'A';

Console.ReadLine();

