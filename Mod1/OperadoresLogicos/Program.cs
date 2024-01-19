/*
 Operadores Lógicos servem para efetuar operações lógicas e sempre retornam True ou False
    && -> AND
    || -> OR
    !  -> NOT
    
Se utiliza, como em toda operação lógica, a tabela verdade para que o resultado lógico seja extraido.
      Condição AND           
    |x|   |y|   |R|
    |0|   |0|   |0|
    |0|   |1|   |0|
    |1|   |0|   |0|
    |1|   |1|   |1|
 
      Condição OR
    |x|   |y|   |R|
    |0|   |0|   |0|
    |0|   |1|   |1|
    |1|   |0|   |1|
    |1|   |1|   |1|

      Condição NOT
       |x|   |R|
       |0|   |1|
       |1|   |0|

 */
Console.WriteLine("Operadores Lógicos!");
Console.WriteLine();

bool x = true;
bool y = false;

bool R;

R = x && y;

Console.WriteLine($"{x} && {y} = {R}");



