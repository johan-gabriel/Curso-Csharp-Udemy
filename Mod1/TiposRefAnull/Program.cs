/*
 Tipos de referencia anuláveis

    É o sistema responsavel por te alertar em possíveis casos de referenciamento NULL, que podem ocorre erros.
    
    NULL CONDICIONAL OPERATOR (?.)
    Tipo NULLABLE (?).
 
 */
Console.WriteLine("Nullable Ref Tipo");

string? nome = null;
Console.WriteLine(nome?.ToUpper());
//                 se nome for NULL não executa o toUpper;
                // se não executa;