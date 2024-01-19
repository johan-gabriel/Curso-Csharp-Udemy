Console.WriteLine("Esse é o método Console.WriteLine! Tipo: Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Mario...";

Console.Write(nome);// método Write escreve o texto sem dar ENTER ou \n
Console.WriteLine(idade);// método WriteLine escreve em uma linha e da \n ou ENTER para proxima


// Usar concatenação: Usando o operador "+";
Console.WriteLine(nome + " tem " + idade + " anos (1)");


// Usar a interpolação de strings: $ -> a interpolação {} ---------- Sistema mais Atual ----------
Console.WriteLine($"{nome} tem {idade} anos (2)");

// Usar place holders: usa {} com numeração com inicio em zero ------- Não tão utilizado --------- C/C++
Console.WriteLine("{0} tem {1} anos", nome, idade);

//Sequência de Scapes ..............
Console.WriteLine("Usando Sequência de escapes!");
Console.WriteLine();

//string local = "c:\dados\poesias.txt"; serve para expressar caracteres que são reservadas para a linguagem por exemplo    ' \ ';
/*
 As sequências de escape são combinações de caracteres consistindo de uma barra invertida (\) seguida por uma letra ou por uma combinação de dígitos.
\a ------ Sinal sonoro (Alerta)
\b ------ Backspace
\f ------ Alinhamento de formulário
\n ------ Nova linha/ Enter
\r ------ Carriage return
\t ------ Tabulação Horizontal
\v ------ """"""""" Vertical
\' ------ Aspas simples
\" ------ Aspas Duplas
\\ ------ Barra invertida 
\? ------ Interrogação
\u ooo -- Caractere ASCII na notação Unicode
\x hh --- Caractere ASCII na notação Hexadecimal
 */


Console.WriteLine(" a mané vou apagar o 3 123\b");
Console.WriteLine("Vô fazer um barulho\a");
Console.WriteLine("Vô \vfazer uma\ttabulação"); // da um espaço grande, similar ao 'tab';
Console.WriteLine("\' e tem também \"");



Console.ReadLine();