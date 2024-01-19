/*
 
 string:
     IMUTÁVEL (valor) - System.Sring

object:
    pode ser qualquer tipo, desde int até strings

dynamic:
    parece object mas na aplicação a baixo pode apresentar peculiaridades
    
 valor padrão delas é null

Tipo Referência

 */

Console.WriteLine("Definindo variáveis do tipo string, object dynamic");
Console.WriteLine();


string nome = "Curso C#";
String titulo = "Curso C# Essencial";


Console.WriteLine(nome);
Console.WriteLine(titulo);

string valor = "Valor inicial";
valor = " Segundo valor";
Console.WriteLine(valor);


// Object
object nota = 10;
object flutuant = 10.5f;
object nomes = "Maria, Johan, Carine";
object ativador = true;
object letra = 'A';

Console.WriteLine(nota);
Console.WriteLine(flutuant);
Console.WriteLine(nomes);
Console.WriteLine(ativador);
Console.WriteLine(letra);

// Dynamic
dynamic nota1 = 10;
dynamic flutuant2 = 10.5f;
dynamic nomes3 = "Maria, Dynamic, Carine";
dynamic ativador4 = true;
dynamic letra5 = 'B';
 /*
  Usado mais em Refletion = usado para retornar metadados de tipos em tempo de execução
  */
Console.WriteLine(nota1);
Console.WriteLine(flutuant2);
Console.WriteLine(nomes3);
Console.WriteLine(ativador4);
Console.WriteLine(letra5);

Console.ReadLine();

