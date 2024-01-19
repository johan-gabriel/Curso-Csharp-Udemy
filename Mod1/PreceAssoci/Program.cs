/*
    A precendencia do operador é um conjunto de regras que define como uma expressão é avaliada.
    Em C# cada operador tem uma prioridade, e com essa prioridade, a expressão é avaliada.
    Se o operador tem maior precedencia são avaçiados primeiro.

    Se a precedencia de dois operadores forem iguais, a regra muda, são avalidaods com base na associatividade
    do operador(sendo da direita para esquerda ou esquerda para direita).
    
    A ordem de precedência:
    Separadores  -> [], ();
    Aritiméticos -> *, /, %, +, -; nesta sequência
    Atribuição   -> =, *=, /=, %=, +=, -=; 
    Incre/Decre  -> ++, -- (pré) ++a;
                    ++, -- (pós) a--;
    Relacionais  -> <, >, <=, >=, ==, !=;
    Lógicos      -> !, &&, ||;

    é quem vem primeiro;
    


 */
Console.WriteLine("Precedência e Associatividade de Operadores!");


int x = 10 - 2 * 3;
Console.WriteLine($"x = 10 - 2 * 3 = {x}");
Console.WriteLine();
int y = (10 - 2) * 3;
Console.WriteLine($"y = (10 - 2) * 3 = {y}");