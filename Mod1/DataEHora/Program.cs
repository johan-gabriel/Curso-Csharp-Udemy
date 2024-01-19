/*
 Ctrl + D copia a linha e da um Entrer!!!!
 
 */

Console.WriteLine("## Struct DateTime ##");

Console.WriteLine();

DateTime data = DateTime.Now;// DateTime.Now impreime a data e hora do compudador...
Console.WriteLine(data);

// Criar uma data expecífica no formato: aaaa;mm;dd

DateTime dataHoje = new DateTime(2020, 09, 06);
Console.WriteLine(dataHoje);

//Criar uma data com o horário no formato: aaaa;mm;dd;/hh;mnmn;ss

DateTime dataHoraHj = new DateTime(2021,09,15,22,37,42);
Console.WriteLine(dataHoraHj);
Console.WriteLine();

//extrair infos da data atual
Console.WriteLine(data.Year); // ************* Extrai o Ano *******************
Console.WriteLine(data.Month);// ************* Extrai o Mês *******************
Console.WriteLine(data.Day);// ************* Extrai o Dia *******************
Console.WriteLine(data.Hour);// ************* Extrai o Hora *******************
Console.WriteLine(data.Minute);// ************* Extrai o Minuto *******************
Console.WriteLine(data.Second);// ************* Extrai o Segundo *******************
Console.WriteLine(data.Millisecond);// ************* Extrai o Mili-Segundo *******************
Console.WriteLine();
// todos os monitorados pelo sistema.

//Adicionando Valores
Console.WriteLine(data.AddDays(30)); //************* Adiciona 30 dias a data atual ****************
Console.WriteLine(data.AddMonths(2));//************* Adiciona 2 meses a data atual ****************
Console.WriteLine(data.AddHours(4));//************* Adiciona 4 horas a data atual ****************
Console.WriteLine(data.AddYears(23));//************* Adiciona 23 anos a data atual ****************
Console.WriteLine();


//obter o dia da semana e do ano
Console.WriteLine(data.DayOfWeek);//************* Extrai o Dia da semana *******************
Console.WriteLine(data.DayOfYear);//************* Extrai o Dia do ano *******************
Console.WriteLine();


//data no formato longo e curto
Console.WriteLine(data.ToLongDateString());//************* Extrai a Data no modo extenço *******************
Console.WriteLine(data.ToShortDateString());//************* Extrai a Data no modo curto *******************
Console.WriteLine(data.ToShortTimeString());//************* Extrai a Hora no modo Curto *******************
Console.WriteLine(data.ToLongTimeString());//************* Extrai a Hora no modo longo *******************
Console.WriteLine();


