/*
 Conversão Implicita:
    O compilaodr C# faz a função de troca de TIPO automaticamnete.(Só em caso de compatibilidade)
    exemplo de compatibilidade 
        INT -> 4bytes
        DOUBLE -> 8bytes
        é possível guardar 4bytes(int) dentro de 8bytes(double)? sim
            então é implicita.

 Conversão Explicita:
    É uma conversão feita manualmente por intermédio de indicadores.
    Neste caso é necessário o uso de Cast...
    exemplo de conversão via cast:
        vardouble= xxxx;
        varint = (cast)vardouble;
                ou seja
        varint = (int)vardouble;
        Perceba que é necessário que o mesmo tipo da var com menor capacidade em bytes seja o cast! E há um efeito colatera neste caso que é
        a perda de dados da casa decimal por conta que valores INT não os possuem.

 Método ToString():
    É um método da classe Object, e retorna uma string que representa o objeto atual.
    Converte um objeto em sua representaçao de caracteres para exibição.
    
 Método da classe Convert():
    Essa classe fornece diversos métodos para converter um tipo de dados em outro tipo de dados.
    
    ToBoolean() - converte um tipo para um valor boolean
    ToChar()    - converte um tipo para um tipo char
    ToDouble()  - converte um tipo para um tipo double
    ToInt16()   - converte um tipo para um tipo 16-bit
    ToInt32()   - converte um tipo para um tipo 32-bit
    ToString()  - Já foi!
 
 */
Console.WriteLine("Conversão de Tipos");
// Tipo de conversão IMPLICITA (Foi automatico);
int varInt = 100;
double varDouble = varInt;

int numINT = 2145678;
long numLong = numINT;
float numFloat = numINT;
double numDouble = numINT;
decimal numDecimal = numINT;
Console.WriteLine("########## Implicita! ###########");
Console.WriteLine(numINT);
Console.WriteLine(numLong);
Console.WriteLine(numFloat);
Console.WriteLine(numDouble);
Console.WriteLine(numDecimal);
Console.WriteLine(varDouble);
Console.WriteLine();
// Tipo de conversão Explicita
double expDouble = 12.5542;
            //(cast) - conversão forçada!
int expInt = (int)expDouble;

int num1 = 10;
int num2 = 20;

float resultadoSem = num1 / num2;
float resultado = (float)num1/num2; // o resultado em cast
Console.WriteLine("########## Explicita! ###########");
Console.WriteLine(expInt);
Console.WriteLine(resultadoSem);
Console.WriteLine(resultado);


//Método ToString()

int numero1 = 1234567788;
double numero2 = 12.45;
decimal numero3 = 12.8563m;

string s1 = numero1.ToString();
string s2 = numero2.ToString();
string s3 = numero3.ToString();
Console.WriteLine("########## Método ToString()! ###########");
Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);
Console.WriteLine("########## Método Convert()! ###########");
Console.WriteLine(Convert.ToDouble(numero1));
Console.WriteLine(Convert.ToInt32(numero3));
//Console.WriteLine(Convert.ToByte(numero1));// OverFlowExeption
