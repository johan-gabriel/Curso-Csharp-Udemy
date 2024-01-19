/*
    *Para ver infos como dia, mÊs hora etc:
        Year, Month, Day, Hour, Second,Millisecond

    *Add :
        AddDays, AddHours, AddMonths, AddYears
    *Get:
        DayOfWeek, DayOfYear
    *Abreviar ou alongar a exibição da data:
        ToLongDateString,ToShortDateString
    *Abreviar ou alongar a exibição da hora:
        ToLongHourString,ToShortHourString
 
 */

Console.WriteLine("DateTime!");

Console.WriteLine();
// Busca a data atual pelo windows
DateTime dataHj = DateTime.Now;

Console.WriteLine(dataHj.ToString());

Console.WriteLine(dataHj.Year);
Console.WriteLine(dataHj.Month);
Console.WriteLine(dataHj.Day);
Console.WriteLine(dataHj.Hour);

//ADD
Console.WriteLine(dataHj.AddDays(30));
Console.WriteLine(dataHj.AddMonths(2));
Console.WriteLine(dataHj.AddYears(2));

//Get
Console.WriteLine(dataHj.DayOfYear);
Console.WriteLine(dataHj.DayOfWeek);

//Long/Short
Console.WriteLine(dataHj.ToLongDateString());
Console.WriteLine(dataHj.ToShortDateString());
Console.WriteLine(dataHj.ToLongTimeString());
Console.WriteLine(dataHj.ToShortTimeString());

// Cria uma data em específico (aaaa,mm,dd,hh,mm,ss)
DateTime dataVj = new DateTime(2022,09,04);

Console.WriteLine(dataVj.ToString());

DateTime dataGata = new DateTime(1999, 04,27, 15,15,20);

Console.WriteLine(dataGata.ToString());


Console.ReadKey();
